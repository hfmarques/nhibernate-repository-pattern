create table Hotel (
    Id int identity(1,1) primary key,
    Nome varchar(255),
    EnderecoId int foreign key references Endereco(Id) 
)

create table Endereco(
    Id int identity(1,1) primary key,
    Numero int,
    Complemento varchar(255),
    Bairro varchar(255),
    Cidade varchar(255),
    Cep varchar(255),
    Uf varchar(255),
    Rua varchar(255)
)

create table Quarto(
    Id int identity(1,1) primary key,
    Tipo varchar(255),
    Cama varchar(255),
    Ocupado bit,
    Numero int,
    HotelId int foreign key references Hotel(Id) 
)

select * from hotel