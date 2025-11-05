USE aile
GO

-- Create schemas only if they don't exist (excluding system schemas)
IF NOT EXISTS(SELECT * FROM sys.schemas WHERE [name] = N'aile')      
     EXEC (N'CREATE SCHEMA aile')                                   
GO                                                               

-- Drop tables in correct order to handle dependencies
-- Drop table with foreign keys first
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'ailefert'  AND sc.name = N'aile'  AND type in (N'U'))
BEGIN
  DECLARE @drop_statement_af nvarchar(500)
  DECLARE drop_cursor_af CURSOR FOR
      SELECT 'ALTER TABLE ' + QUOTENAME(schema_name(ob.schema_id)) + '.' + QUOTENAME(object_name(ob.object_id)) + ' DROP CONSTRAINT ' + QUOTENAME(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id
             WHERE so.name = N'ailefert'  AND sc.name = N'aile'  AND type in (N'U')
           )

  OPEN drop_cursor_af
  FETCH NEXT FROM drop_cursor_af INTO @drop_statement_af
  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement_af)
     FETCH NEXT FROM drop_cursor_af INTO @drop_statement_af
  END
  CLOSE drop_cursor_af
  DEALLOCATE drop_cursor_af
  DROP TABLE [aile].[ailefert]
END 
GO

-- Drop bagisturu table (has foreign key reference to aile)
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'bagisturu'  AND sc.name = N'aile'  AND type in (N'U'))
BEGIN
  DECLARE @drop_statement_bt nvarchar(500)
  DECLARE drop_cursor_bt CURSOR FOR
      SELECT 'ALTER TABLE ' + QUOTENAME(schema_name(ob.schema_id)) + '.' + QUOTENAME(object_name(ob.object_id)) + ' DROP CONSTRAINT ' + QUOTENAME(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id
             WHERE so.name = N'bagisturu'  AND sc.name = N'aile'  AND type in (N'U')
           )

  OPEN drop_cursor_bt
  FETCH NEXT FROM drop_cursor_bt INTO @drop_statement_bt
  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement_bt)
     FETCH NEXT FROM drop_cursor_bt INTO @drop_statement_bt
  END
  CLOSE drop_cursor_bt
  DEALLOCATE drop_cursor_bt
  DROP TABLE [aile].[bagisturu]
END 
GO

-- Drop other tables
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'aile'  AND sc.name = N'aile'  AND type in (N'U'))
BEGIN
  DECLARE @drop_statement_a nvarchar(500)
  DECLARE drop_cursor_a CURSOR FOR
      SELECT 'ALTER TABLE ' + QUOTENAME(schema_name(ob.schema_id)) + '.' + QUOTENAME(object_name(ob.object_id)) + ' DROP CONSTRAINT ' + QUOTENAME(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id
             WHERE so.name = N'aile'  AND sc.name = N'aile'  AND type in (N'U')
           )

  OPEN drop_cursor_a
  FETCH NEXT FROM drop_cursor_a INTO @drop_statement_a
  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement_a)
     FETCH NEXT FROM drop_cursor_a INTO @drop_statement_a
  END
  CLOSE drop_cursor_a
  DEALLOCATE drop_cursor_a
  DROP TABLE [aile].[aile]
END 
GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'kullanici'  AND sc.name = N'aile'  AND type in (N'U'))
BEGIN
  DECLARE @drop_statement_k nvarchar(500)
  DECLARE drop_cursor_k CURSOR FOR
      SELECT 'ALTER TABLE ' + QUOTENAME(schema_name(ob.schema_id)) + '.' + QUOTENAME(object_name(ob.object_id)) + ' DROP CONSTRAINT ' + QUOTENAME(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id
             WHERE so.name = N'kullanici'  AND sc.name = N'aile'  AND type in (N'U')
           )

  OPEN drop_cursor_k
  FETCH NEXT FROM drop_cursor_k INTO @drop_statement_k
  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement_k)
     FETCH NEXT FROM drop_cursor_k INTO @drop_statement_k
  END
  CLOSE drop_cursor_k
  DEALLOCATE drop_cursor_k
  DROP TABLE [aile].[kullanici]
END 
GO

-- Drop bagisyapan_kurum table
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'bagisyapan_kurum'  AND sc.name = N'aile'  AND type in (N'U'))
BEGIN
  DECLARE @drop_statement_bk nvarchar(500)
  DECLARE drop_cursor_bk CURSOR FOR
      SELECT 'ALTER TABLE ' + QUOTENAME(schema_name(ob.schema_id)) + '.' + QUOTENAME(object_name(ob.object_id)) + ' DROP CONSTRAINT ' + QUOTENAME(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id
             WHERE so.name = N'bagisyapan_kurum'  AND sc.name = N'aile'  AND type in (N'U')
           )
  OPEN drop_cursor_bk
  FETCH NEXT FROM drop_cursor_bk INTO @drop_statement_bk
  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement_bk)
     FETCH NEXT FROM drop_cursor_bk INTO @drop_statement_bk
  END
  CLOSE drop_cursor_bk
  DEALLOCATE drop_cursor_bk
  DROP TABLE [aile].[bagisyapan_kurum]
END 
GO

-- Create tables in correct order (referenced tables first)

-- Create bagisyapan_kurum table
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [aile].[bagisyapan_kurum]
(
   [KurumId] int IDENTITY(1,1) NOT NULL,
   [KurumAdi] nvarchar(100) NOT NULL,
   [YetkiliAdSoyad] nvarchar(100) NOT NULL,
   [Telefon] nvarchar(20),
   [Email] nvarchar(100),
   [Adres] nvarchar(255),
   [KayitTarihi] date NOT NULL,
   [Guncelleme] date NOT NULL
);
GO

-- Create aile table
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[aile].[aile]
(
   [AileId] int IDENTITY(1,1) NOT NULL,
   [TC] int  NOT NULL,
   [AileAd] nvarchar(45)  NOT NULL,
   [Telefon] nvarchar(45)  NOT NULL,
   [Adres] nvarchar(45)  NOT NULL,
   [KayitTarihi] date  NOT NULL,
   [Guncelleme] date  NOT NULL,
   [KurumId] int NULL  -- Changed from KurumAdi to KurumId to reference bagisyapan_kurum
)
WITH (DATA_COMPRESSION = NONE)
GO

-- Create ailefert table
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[aile].[ailefert]
(
   [key_Id] int IDENTITY(1,1) NOT NULL,  -- Changed to IDENTITY
   [key_AileId] int  NOT NULL,
   [TC] int  NOT NULL,
   [AdSoyad] nvarchar(45)  NOT NULL,
   [Kayıt] date  NOT NULL,
   [Guncelleme] date  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO

-- Create kullanici table
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[aile].[kullanici]
(
   [Id] int IDENTITY(1,1) NOT NULL,
   [KullaniciAdi] nvarchar(45)  NOT NULL,
   [Sifre] nvarchar(MAX)  NOT NULL,
   [KullaniciRol] nvarchar(45)  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO

-- Create bagisturu table
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[aile].[bagisturu]
(
   [Id] int IDENTITY(1,1) NOT NULL,
   [BagisTuru1] nvarchar(50) NOT NULL,  -- Changed to match your C# entity property
   [Aciklama] nvarchar(200) NOT NULL,
   [Durum] nvarchar(20) NULL,  -- Changed to match your C# entity property and added appropriate type
   [Miktar] decimal(18,2) NULL  -- Changed to match your C# entity property and added appropriate type
)
WITH (DATA_COMPRESSION = NONE)
GO

-- Add extended properties
BEGIN TRY
    EXEC sp_addextendedproperty N'MS_SSMA_SOURCE', N'aile.aile', N'SCHEMA', N'aile', N'TABLE', N'aile'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

BEGIN TRY
    EXEC sp_addextendedproperty N'MS_SSMA_SOURCE', N'aile.ailefert', N'SCHEMA', N'aile', N'TABLE', N'ailefert'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

BEGIN TRY
    EXEC sp_addextendedproperty N'MS_SSMA_SOURCE', N'aile.bagisyapan_kurum', N'SCHEMA', N'aile', N'TABLE', N'bagisyapan_kurum'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

BEGIN TRY
    EXEC sp_addextendedproperty N'MS_SSMA_SOURCE', N'aile.kullanici', N'SCHEMA', N'aile', N'TABLE', N'kullanici'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

BEGIN TRY
    EXEC sp_addextendedproperty N'MS_SSMA_SOURCE', N'aile.bagisturu', N'SCHEMA', N'aile', N'TABLE', N'bagisturu'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO

-- Add primary keys
ALTER TABLE [aile].[bagisyapan_kurum]
 ADD CONSTRAINT [PK_bagisyapan_kurum_KurumId]
   PRIMARY KEY
   CLUSTERED ([KurumId] ASC)
GO

ALTER TABLE [aile].[aile]
 ADD CONSTRAINT [PK_aile_AileId]
   PRIMARY KEY
   CLUSTERED ([AileId] ASC)
GO

ALTER TABLE [aile].[ailefert]
 ADD CONSTRAINT [PK_ailefert_key_Id]
   PRIMARY KEY
   CLUSTERED ([key_Id] ASC)
GO

ALTER TABLE [aile].[kullanici]
 ADD CONSTRAINT [PK_kullanici_Id]
   PRIMARY KEY
   CLUSTERED ([Id] ASC)
GO

ALTER TABLE [aile].[bagisturu]
 ADD CONSTRAINT [PK_bagisturu_Id]
   PRIMARY KEY
   CLUSTERED ([Id] ASC)
GO

-- Add foreign keys
ALTER TABLE [aile].[aile]
ADD CONSTRAINT [FK_aile_bagisyapan_kurum_KurumId]
FOREIGN KEY ([KurumId]) REFERENCES [aile].[bagisyapan_kurum]([KurumId])
GO

ALTER TABLE [aile].[ailefert]
ADD CONSTRAINT [FK_ailefert_aile_AileId]
FOREIGN KEY ([key_AileId]) REFERENCES [aile].[aile]([AileId])
GO

-- bagisturu table doesn't have a foreign key to aile based on your C# code, removing this constraint
-- If you need a foreign key from bagisturu to aile, you need to add a column in bagisturu
-- ALTER TABLE [aile].[bagisturu]
-- ADD CONSTRAINT [FK_bagisturu_aile_AileId]
-- FOREIGN KEY ([key_AileId]) REFERENCES [aile].[aile]([AileId])
GO