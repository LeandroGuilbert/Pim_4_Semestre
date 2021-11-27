
create table tb_categoria
(
    cl_id int primary key identity,
    desc_categoria nvarchar(50) not null,
   
)

create table tb_cliente
(
	id int primary key identity,
	nome nvarchar(50) not null,
	email nvarchar(50) not null,
	celular nvarchar(50) not null,
	foto image not null,
	data date not null,
	CPF numeric(50) not null,

)
create table tb_contasreceber
(
	id_conta int primary key identity,
	data_compra datetime not null,
	data_vencimento datetime not null,
	data_pagamento datetime not null,
	id_venda int not null,
	id_status int not null,
)
create table tb_itens_venda
(
	quantidade int not null,
	id_produto int not null,
	id_venda int not null,
	valor decimal(15,2) not null,
	id_item int primary key identity,
)
create table tb_pessoa
(
	id_pessoa int primary key identity,
	desc_pessoa datetime not null,
	
)
create table tb_produto
(
	id_produto int primary key identity,
	desc_produto nvarchar(50) not null,
	valor decimal(25,2) not null,
	id_categoria int not null,
	
)
create table tb_status
(
	id_status int primary key identity,
	status nvarchar(50) not null,
)
create table tb_usuario
(
	
	usuario nvarchar(50) not null,
	senha nvarchar(50) not null,
	id_pessoa int primary key identity,
)
create table tb_venda
(
	id_venda int primary key identity,
	valor decimal(15,2) not null,
	desconto decimal(15,2) not null,
	valor_pago decimal(15,2) not null,
	id_pessoa int not null,
)

