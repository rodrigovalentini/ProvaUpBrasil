IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [TB_CLIENTE] (
    [Id] uniqueidentifier NOT NULL,
    [Nom_cliente] varchar(80) NOT NULL,
    [Dt_cadastramento] datetime2 NOT NULL,
    [Des_observacao] varchar(255) NOT NULL,
    [Fl_ativo] bit NOT NULL,
    CONSTRAINT [PK_TB_CLIENTE] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [TB_GRUPO_ITEM] (
    [Id] uniqueidentifier NOT NULL,
    [Nom_grupo_item] varchar(80) NOT NULL,
    [Des_grupo_item] varchar(255) NOT NULL,
    [Fl_ativo] bit NOT NULL,
    CONSTRAINT [PK_TB_GRUPO_ITEM] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [TB_STATUS_VENDA] (
    [Id] uniqueidentifier NOT NULL,
    [Nom_status_venda] varchar(80) NOT NULL,
    [Des_status_venda] varchar(255) NOT NULL,
    [Fl_ativo] bit NOT NULL,
    CONSTRAINT [PK_TB_STATUS_VENDA] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [TB_TIPO_ENDERECO] (
    [Id] uniqueidentifier NOT NULL,
    [nom_tipo_endereco] varchar(80) NOT NULL,
    [Des_tipo_endereco] varchar(255) NOT NULL,
    [Fl_ativo] bit NOT NULL,
    CONSTRAINT [PK_TB_TIPO_ENDERECO] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [TB_TIPO_TELEFONE] (
    [Id] uniqueidentifier NOT NULL,
    [Nom_tipo_telefone] varchar(80) NOT NULL,
    [Fl_ativo] bit NOT NULL,
    CONSTRAINT [PK_TB_TIPO_TELEFONE] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [TB_TIPO_VENDA] (
    [Id] uniqueidentifier NOT NULL,
    [Nom_tipo_venda] varchar(80) NOT NULL,
    [Des_tipo_venda] varchar(255) NOT NULL,
    [Fl_ativo] bit NOT NULL,
    CONSTRAINT [PK_TB_TIPO_VENDA] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [TB_UF] (
    [Id] uniqueidentifier NOT NULL,
    [Nom_uf] varchar(80) NOT NULL,
    [Sgl_uf] char(2) NOT NULL,
    [Fl_ativo] bit NOT NULL,
    CONSTRAINT [PK_TB_UF] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [TB_VENDEDOR] (
    [Id] uniqueidentifier NOT NULL,
    [Nom_vendedor] varchar(80) NOT NULL,
    [Dt_cadastramento] datetime2 NOT NULL,
    [Fl_ativo] bit NOT NULL,
    CONSTRAINT [PK_TB_VENDEDOR] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [TB_TELEFONE_CLIENTE] (
    [Id] uniqueidentifier NOT NULL,
    [Idt_num_telefone] varchar(18) NOT NULL,
    [Idt_codigo_area] varchar(18) NOT NULL,
    [Des_observacao] varchar(255) NOT NULL,
    [Fl_ativo] bit NOT NULL,
    [Cod_cliente] uniqueidentifier NOT NULL,
    [Cod_tipo_telefone] uniqueidentifier NOT NULL,
    [ClienteId] uniqueidentifier NULL,
    CONSTRAINT [PK_TB_TELEFONE_CLIENTE] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TB_TELEFONE_CLIENTE_TB_CLIENTE_ClienteId] FOREIGN KEY ([ClienteId]) REFERENCES [TB_CLIENTE] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_TB_TELEFONE_CLIENTE_TB_TIPO_TELEFONE_Cod_tipo_telefone] FOREIGN KEY ([Cod_tipo_telefone]) REFERENCES [TB_TIPO_TELEFONE] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [TB_CIDADE] (
    [Id] uniqueidentifier NOT NULL,
    [Nom_cidade] varchar(80) NOT NULL,
    [Fl_ativo] bit NOT NULL,
    [Cod_uf] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_TB_CIDADE] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TB_CIDADE_TB_UF_Cod_uf] FOREIGN KEY ([Cod_uf]) REFERENCES [TB_UF] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [TB_VENDA] (
    [Id] uniqueidentifier NOT NULL,
    [Dt_cadastramento] datetime2 NOT NULL,
    [Dt_venda] datetime2 NOT NULL,
    [Vlr_total_item] decimal(10,2) NOT NULL,
    [Vlr_total_desconto] decimal(10,2) NOT NULL,
    [Vlr_total_venda] decimal(10,2) NOT NULL,
    [Des_observacao] varchar(255) NOT NULL,
    [Cod_tipo_venda] uniqueidentifier NOT NULL,
    [Cod_status_venda] uniqueidentifier NOT NULL,
    [Cod_vendedor] uniqueidentifier NOT NULL,
    [Cod_cliente] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_TB_VENDA] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TB_VENDA_TB_CLIENTE_Cod_cliente] FOREIGN KEY ([Cod_cliente]) REFERENCES [TB_CLIENTE] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_TB_VENDA_TB_STATUS_VENDA_Cod_status_venda] FOREIGN KEY ([Cod_status_venda]) REFERENCES [TB_STATUS_VENDA] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_TB_VENDA_TB_TIPO_VENDA_Cod_tipo_venda] FOREIGN KEY ([Cod_tipo_venda]) REFERENCES [TB_TIPO_VENDA] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_TB_VENDA_TB_VENDEDOR_Cod_vendedor] FOREIGN KEY ([Cod_vendedor]) REFERENCES [TB_VENDEDOR] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [TB_BAIRRO] (
    [Id] uniqueidentifier NOT NULL,
    [Nom_bairro] varchar(80) NOT NULL,
    [Fl_ativo] bit NOT NULL,
    [Cod_cidade] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_TB_BAIRRO] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TB_BAIRRO_TB_CIDADE_Cod_cidade] FOREIGN KEY ([Cod_cidade]) REFERENCES [TB_CIDADE] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [TB_ENDERECO_CLIENTE] (
    [Id] uniqueidentifier NOT NULL,
    [Des_endereco] varchar(255) NOT NULL,
    [Des_complemento] varchar(255) NOT NULL,
    [Idt_caixa_postal] varchar(18) NOT NULL,
    [Idt_cep] varchar(18) NOT NULL,
    [Des_observacao] varchar(255) NOT NULL,
    [Fl_ativo] bit NOT NULL,
    [Cod_cliente] uniqueidentifier NOT NULL,
    [Cod_tipo_endereco] uniqueidentifier NOT NULL,
    [Cod_bairro] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_TB_ENDERECO_CLIENTE] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TB_ENDERECO_CLIENTE_TB_BAIRRO_Cod_bairro] FOREIGN KEY ([Cod_bairro]) REFERENCES [TB_BAIRRO] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_TB_ENDERECO_CLIENTE_TB_CLIENTE_Cod_cliente] FOREIGN KEY ([Cod_cliente]) REFERENCES [TB_CLIENTE] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_TB_ENDERECO_CLIENTE_TB_TIPO_ENDERECO_Cod_tipo_endereco] FOREIGN KEY ([Cod_tipo_endereco]) REFERENCES [TB_TIPO_ENDERECO] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [TB_ITEM] (
    [Id] uniqueidentifier NOT NULL,
    [Nom_item] varchar(80) NOT NULL,
    [Qtd_Item] decimal(10,2) NOT NULL,
    [Qtd_minima_item] decimal(10,2) NOT NULL,
    [Vlr_item] decimal(10,2) NOT NULL,
    [Dt_cadastramento] datetime2 NOT NULL,
    [Fl_ativo] bit NOT NULL,
    [Cod_grupo_item] uniqueidentifier NOT NULL,
    [Cod_tipo_item] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_TB_ITEM] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TB_ITEM_TB_GRUPO_ITEM_Cod_grupo_item] FOREIGN KEY ([Cod_grupo_item]) REFERENCES [TB_GRUPO_ITEM] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [TB_TIPO_ITEM] (
    [Id] uniqueidentifier NOT NULL,
    [Nom_tipo_item] varchar(80) NOT NULL,
    [Des_tipo_item] varchar(255) NOT NULL,
    [Fl_ativo] bit NOT NULL,
    [ItemId] uniqueidentifier NULL,
    [Cod_item] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_TB_TIPO_ITEM] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TB_TIPO_ITEM_TB_ITEM_ItemId] FOREIGN KEY ([ItemId]) REFERENCES [TB_ITEM] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [TB_VENDA_ITEM] (
    [Id] uniqueidentifier NOT NULL,
    [Qtd_item] decimal(10,2) NOT NULL,
    [Vlr_item] decimal(10,2) NOT NULL,
    [Vlr_desconto] decimal(10,2) NOT NULL,
    [Vlr_total_item] decimal(10,2) NOT NULL,
    [Cod_item] uniqueidentifier NOT NULL,
    [Cod_venda] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_TB_VENDA_ITEM] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TB_VENDA_ITEM_TB_ITEM_Cod_item] FOREIGN KEY ([Cod_item]) REFERENCES [TB_ITEM] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_TB_VENDA_ITEM_TB_VENDA_Cod_venda] FOREIGN KEY ([Cod_venda]) REFERENCES [TB_VENDA] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_TB_BAIRRO_Cod_cidade] ON [TB_BAIRRO] ([Cod_cidade]);

GO

CREATE INDEX [IX_TB_CIDADE_Cod_uf] ON [TB_CIDADE] ([Cod_uf]);

GO

CREATE INDEX [IX_TB_ENDERECO_CLIENTE_Cod_bairro] ON [TB_ENDERECO_CLIENTE] ([Cod_bairro]);

GO

CREATE INDEX [IX_TB_ENDERECO_CLIENTE_Cod_cliente] ON [TB_ENDERECO_CLIENTE] ([Cod_cliente]);

GO

CREATE INDEX [IX_TB_ENDERECO_CLIENTE_Cod_tipo_endereco] ON [TB_ENDERECO_CLIENTE] ([Cod_tipo_endereco]);

GO

CREATE INDEX [IX_TB_ITEM_Cod_grupo_item] ON [TB_ITEM] ([Cod_grupo_item]);

GO

CREATE INDEX [IX_TB_ITEM_Cod_tipo_item] ON [TB_ITEM] ([Cod_tipo_item]);

GO

CREATE INDEX [IX_TB_TELEFONE_CLIENTE_ClienteId] ON [TB_TELEFONE_CLIENTE] ([ClienteId]);

GO

CREATE INDEX [IX_TB_TELEFONE_CLIENTE_Cod_tipo_telefone] ON [TB_TELEFONE_CLIENTE] ([Cod_tipo_telefone]);

GO

CREATE INDEX [IX_TB_TIPO_ITEM_ItemId] ON [TB_TIPO_ITEM] ([ItemId]);

GO

CREATE INDEX [IX_TB_VENDA_Cod_cliente] ON [TB_VENDA] ([Cod_cliente]);

GO

CREATE INDEX [IX_TB_VENDA_Cod_status_venda] ON [TB_VENDA] ([Cod_status_venda]);

GO

CREATE INDEX [IX_TB_VENDA_Cod_tipo_venda] ON [TB_VENDA] ([Cod_tipo_venda]);

GO

CREATE INDEX [IX_TB_VENDA_Cod_vendedor] ON [TB_VENDA] ([Cod_vendedor]);

GO

CREATE INDEX [IX_TB_VENDA_ITEM_Cod_item] ON [TB_VENDA_ITEM] ([Cod_item]);

GO

CREATE INDEX [IX_TB_VENDA_ITEM_Cod_venda] ON [TB_VENDA_ITEM] ([Cod_venda]);

GO

ALTER TABLE [TB_ITEM] ADD CONSTRAINT [FK_TB_ITEM_TB_TIPO_ITEM_Cod_tipo_item] FOREIGN KEY ([Cod_tipo_item]) REFERENCES [TB_TIPO_ITEM] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201022033909_Initial', N'2.2.6-servicing-10079');

GO

