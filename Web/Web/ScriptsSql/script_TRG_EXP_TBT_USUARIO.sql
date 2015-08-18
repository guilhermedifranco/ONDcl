USE [IDB_CANATIBA]
GO

/****** Object:  Trigger [TRG_EXP_TBT_USUARIO]    Script Date: 05/22/2015 11:33:04 ******/
IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[TRG_EXP_TBT_USUARIO]'))
DROP TRIGGER [dbo].[TRG_EXP_TBT_USUARIO]
GO

USE [IDB_CANATIBA]
GO

/****** Object:  Trigger [dbo].[TRG_EXP_TBT_USUARIO]    Script Date: 05/22/2015 11:33:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE TRIGGER [dbo].[TRG_EXP_TBT_USUARIO] ON [dbo].[TBT_USUARIO] FOR INSERT, UPDATE, DELETE AS 
BEGIN 


    IF (SELECT COUNT(*) FROM inserted)  > 0 
    BEGIN 
        IF (SELECT COUNT(*) FROM deleted) > 0 
        BEGIN 
            -- update! 
			IF NOT UPDATE(CtrlDataOperacao)
			BEGIN
				UPDATE dbo.TBT_USUARIO
				SET CtrlDataOperacao = GETDATE()
				FROM dbo.TBT_USUARIO
				INNER JOIN inserted ON TBT_USUARIO.CodUsuario = inserted.CodUsuario


				UPDATE dbo.AFV_TABELA_SINCRONIZACAO_TBT SET UltimaAtualizacao = GETDATE() WHERE NomeTabela = 'TBT_USUARIO'

			END
        END 
        ELSE 
        BEGIN 
            -- insert! 
			UPDATE dbo.TBT_USUARIO
			SET CtrlDataOperacao = GETDATE(), ID = inserted.CodUsuario
			FROM dbo.TBT_USUARIO
			INNER JOIN inserted ON TBT_USUARIO.CodUsuario = inserted.CodUsuario



			UPDATE dbo.AFV_TABELA_SINCRONIZACAO_TBT SET UltimaAtualizacao = GETDATE() WHERE NomeTabela = 'TBT_USUARIO'
        END 
        
        
    END 
END

GO


