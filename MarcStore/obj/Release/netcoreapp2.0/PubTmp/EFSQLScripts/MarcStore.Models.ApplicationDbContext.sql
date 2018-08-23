IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180821195218_Initial')
BEGIN
    CREATE TABLE [Favorites] (
        [FavoriteID] int NOT NULL IDENTITY,
        [ProductID] int NOT NULL,
        [UserID] nvarchar(max) NULL,
        [Loved] bit NOT NULL,
        CONSTRAINT [PK_Favorites] PRIMARY KEY ([FavoriteID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180821195218_Initial')
BEGIN
    CREATE TABLE [Orders] (
        [OrderID] int NOT NULL IDENTITY,
        [Shipped] bit NOT NULL,
        [Name] nvarchar(max) NOT NULL,
        [Line1] nvarchar(max) NOT NULL,
        [Line2] nvarchar(max) NULL,
        [Line3] nvarchar(max) NULL,
        [City] nvarchar(max) NOT NULL,
        [State] nvarchar(max) NOT NULL,
        [Zip] nvarchar(max) NULL,
        [Country] nvarchar(max) NOT NULL,
        [GiftWrap] bit NOT NULL,
        CONSTRAINT [PK_Orders] PRIMARY KEY ([OrderID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180821195218_Initial')
BEGIN
    CREATE TABLE [Products] (
        [ProductID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NOT NULL,
        [Price] decimal(18, 2) NOT NULL,
        [Category] nvarchar(max) NOT NULL,
        [Text] nvarchar(max) NOT NULL,
        [ImageData] varbinary(max) NULL,
        [ImageMimeType] nvarchar(max) NULL,
        CONSTRAINT [PK_Products] PRIMARY KEY ([ProductID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180821195218_Initial')
BEGIN
    CREATE TABLE [Cart] (
        [CartLineID] int NOT NULL IDENTITY,
        [ProductID] int NULL,
        [Quantity] int NOT NULL,
        [OrderID] int NULL,
        CONSTRAINT [PK_Cart] PRIMARY KEY ([CartLineID]),
        CONSTRAINT [FK_Cart_Orders_OrderID] FOREIGN KEY ([OrderID]) REFERENCES [Orders] ([OrderID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Cart_Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [Products] ([ProductID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180821195218_Initial')
BEGIN
    CREATE INDEX [IX_Cart_OrderID] ON [Cart] ([OrderID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180821195218_Initial')
BEGIN
    CREATE INDEX [IX_Cart_ProductID] ON [Cart] ([ProductID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180821195218_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180821195218_Initial', N'2.1.1-rtm-30846');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180821195244_Orders')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180821195244_Orders', N'2.1.1-rtm-30846');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180821195300_ShippedOrders')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180821195300_ShippedOrders', N'2.1.1-rtm-30846');
END;

GO

