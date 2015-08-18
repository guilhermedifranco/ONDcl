using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Web.Business;
using Web.Messages;
using Web.Models;
using Web.Utils;

namespace Web.Controllers
{
    public class MARKETINGController : Controller
    {
        private SmartBagEntities db = new SmartBagEntities();

        #region private Helpers
        private void ComboStatus(bool? active = null)
        {
            List<SelectListItem> lista = new List<SelectListItem>();

            lista.Add(new SelectListItem { Value = "1", Text = "Ativo" });
            lista.Add(new SelectListItem { Value = "0", Text = "Inativo" });
            if (active == null)
                ViewBag.Status = new SelectList(lista, "Value", "Text");
            else
            { 
                if (active.Value)
                    ViewBag.Status = new SelectList(lista, "Value", "Text", "1");
                else
                    ViewBag.Status = new SelectList(lista, "Value", "Text", "0");
            }
        }
        private string GetTipoArquivo(string formato)
        {
            string tipo = "";
            switch (formato.ToUpper())
            { 
                case ".MP4":
                case ".AVI":
                case ".MPEG":
                case ".MPG":
                    tipo = "VID";
                    break;
                case ".JPG":
                case ".JPEG":
                case ".PNG":
                case ".BMP":
                    tipo = "IMG";
                    break;
                default:
                    tipo = "DIF";
                    break;
            }
            return tipo;
        }
        private void SaveFTP(HttpPostedFileBase file, int CodMarketing, string ArquivoAntigo)
        {
            #region deleteOldFile
            if (!string.IsNullOrEmpty(ArquivoAntigo))
            {
                try {
                    string DEL_URIString = ParametrosBLL.GetParameter("FTPServer") + "/" + ParametrosBLL.GetParameter("FTPMarketing") + "/" + ArquivoAntigo;
                    FtpWebRequest DEL_request = (FtpWebRequest)WebRequest.Create(DEL_URIString);
                    DEL_request.Credentials = new NetworkCredential(ParametrosBLL.GetParameter("FTPUser"), ParametrosBLL.GetParameter("FTPPwd"));
                    DEL_request.Method = WebRequestMethods.Ftp.DeleteFile;
                    FtpWebResponse DEL_response = (FtpWebResponse)DEL_request.GetResponse();
                    Console.WriteLine("Delete status: {0}", DEL_response.StatusDescription);
                    DEL_response.Close();
                }
                catch (Exception)
                { }

            }
            #endregion

            string fileName = CodMarketing.ToString() + "_" + Path.GetFileName(file.FileName);
            string URIString = ParametrosBLL.GetParameter("FTPServer") + "/" + ParametrosBLL.GetParameter("FTPMarketing") + "/" + fileName;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(URIString);
            request.Method = WebRequestMethods.Ftp.UploadFile;

            request.Credentials = new NetworkCredential(ParametrosBLL.GetParameter("FTPUser"), ParametrosBLL.GetParameter("FTPPwd"));

            var sourceStream = file.InputStream;
            Stream requestStream = request.GetRequestStream();
            request.ContentLength = sourceStream.Length;
            byte[] buffer = new byte[file.ContentLength];
            int bytesRead = sourceStream.Read(buffer, 0, file.ContentLength);
            do
            {
                requestStream.Write(buffer, 0, bytesRead);
                bytesRead = sourceStream.Read(buffer, 0, file.ContentLength);
            } while (bytesRead > 0);
            sourceStream.Close();
            requestStream.Close();
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

        }
        #endregion

        #region Index/Pesquisa
        public ActionResult Index()
        {
            ComboStatus(true);
            ViewBag.TipoMarketing = new SelectList(db.TBT_TIPO_MARKETING, "CodTipoMarketing", "Descricao");
            MarketingBLL BLL = new MarketingBLL();
            var ListaConsulta = BLL.SearchMarketing(1, null, null, null);
            return View(ListaConsulta);
        }
        public ActionResult Pesquisa([Bind(Include = "Status, TipoMarketing, Descricao, Titulo")] int? Status, int? TipoMarketing, string Descricao, string Titulo)
        {
            ComboStatus();
            ViewBag.TipoMarketing = new SelectList(db.TBT_TIPO_MARKETING, "CodTipoMarketing", "Descricao");

            MarketingBLL BLL = new MarketingBLL();

            var ListaConsulta = BLL.SearchMarketing(Status, TipoMarketing, Descricao, Titulo);

            return PartialView("_PartialMarketing", ListaConsulta);
        }
        #endregion

        #region Edição
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MarketingBLL BLL = new MarketingBLL();
            Marketing tBT_Marketing = BLL.GetMarketing(id);

            if (tBT_Marketing == null)
            {
                return HttpNotFound();
            }
            ComboStatus(tBT_Marketing.Ativo);
            ViewBag.CodTipoMarketing = new SelectList(db.TBT_TIPO_MARKETING, "CodTipoMarketing", "Descricao", tBT_Marketing.CodTipoMarketing);
            ViewBag.CodMarca = new SelectList(db.TBT_MARCA, "CodMarca", "Descricao", tBT_Marketing.CodMarca);
            return View(tBT_Marketing);
        }
        // POST: TBT_USER/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Status, Arquivo, Titulo, Descricao, CodTipoMarketing, CodMarca")] int Status, HttpPostedFileBase Arquivo, Marketing MKT)
        {
            MarketingBLL BLL = new MarketingBLL();
            Marketing OldMarketing = BLL.GetMarketing(MKT.CodMarketing);
            string ArquivoAntigo = OldMarketing.NomeArquivo;
            string TipoARquivoAntigo = OldMarketing.TipoArquivo;
            MKT.Ativo = Status == 1;
            if (ModelState.IsValid)
            {
                if (Arquivo != null && Arquivo.ContentLength > 0)
                {
                    var fileName = MKT.CodMarketing.ToString() + "_" + Path.GetFileName(Arquivo.FileName);
                    string fileExtension = System.IO.Path.GetExtension(fileName);
                    MKT.NomeArquivo = fileName;
                    MKT.TipoArquivo = GetTipoArquivo(fileExtension);
                }
                else
                {
                    MKT.NomeArquivo = ArquivoAntigo;
                    MKT.TipoArquivo = TipoARquivoAntigo;
                }
                bool saved = BLL.SaveEdit(MKT);
                if (saved)
                {
                    if (Arquivo != null && Arquivo.ContentLength > 0)
                    {
                        try
                        {
                            SaveFTP(Arquivo, MKT.CodMarketing, ArquivoAntigo);
                        }
                        catch(Exception)
                        {
                            TempData["Marketing"] = "Failure";
                            TempData["Message"] = "Ocorreu um erro ao tentar salvar o arquivo do marketing no servidor FTP.";
                            return RedirectToAction("Index");
                        }
                        
                    }
                    TempData["Marketing"] = "Success";
                    TempData["Message"] = "Marketing editado com sucesso!";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Marketing"] = "Failure";
                    TempData["Message"] = "Ocorreu um erro ao tentar salvar o marketing.";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["Marketing"] = "Failure";
                TempData["Message"] = "Ocorreu um erro ao tentar salvar o marketing.";
                return RedirectToAction("Index");
            }
        }
        #endregion


        // GET: TBT_USER/Create
        public ActionResult Create()
        {
            ViewData["errovalidation"] = "";
            ViewData["sucessovalidation"] = "";

            ViewBag.CodTipoMarketing = new SelectList(db.TBT_TIPO_MARKETING, "CodTipoMarketing", "Descricao");
            ViewBag.CodMarca = new SelectList(db.TBT_MARCA, "CodMarca", "Descricao", "1");
            return View();
        }

        // POST: TBT_USER/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Arquivo, Titulo, Descricao, CodTipoMarketing, CodMarca")] HttpPostedFileBase Arquivo, Marketing MKT)
        {
            MarketingBLL BLL = new MarketingBLL();
            MKT.Ativo = true;
            MKT = BLL.IncluirMkt(MKT);
            if (Arquivo != null && Arquivo.ContentLength > 0)
            {
                var fileName = MKT.CodMarketing.ToString() + "_" + Path.GetFileName(Arquivo.FileName);
                string fileExtension = System.IO.Path.GetExtension(fileName);
                MKT.NomeArquivo = fileName;
                MKT.TipoArquivo = GetTipoArquivo(fileExtension);
            }
            
            if (MKT != null)
            {
                if (Arquivo != null && Arquivo.ContentLength > 0)
                {
                    try
                    {
                        var fileName = MKT.CodMarketing.ToString() + "_" + Path.GetFileName(Arquivo.FileName);
                        string fileExtension = System.IO.Path.GetExtension(fileName);
                        MKT.NomeArquivo = fileName;
                        MKT.TipoArquivo = GetTipoArquivo(fileExtension);
                        SaveFTP(Arquivo, MKT.CodMarketing, null);
                        bool saved = BLL.SaveEdit(MKT);
                        if (!saved)
                        {
                            TempData["Marketing"] = "Failure";
                            TempData["Message"] = "Ocorreu um erro ao tentar atualizar o nome do arquivo de marketing.";
                            return RedirectToAction("Index");
                        }
                    }
                    catch (Exception)
                    {
                        TempData["Marketing"] = "Failure";
                        TempData["Message"] = "Ocorreu um erro ao tentar salvar o arquivo do marketing no servidor FTP.";
                        return RedirectToAction("Index");
                    }

                }
                TempData["Marketing"] = "Success";
                TempData["Message"] = "Marketing incluído com sucesso!";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Marketing"] = "Failure";
                TempData["Message"] = "Ocorreu um erro ao tentar salvar o marketing.";
                return RedirectToAction("Index");
            }
        }

        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
