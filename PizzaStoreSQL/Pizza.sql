use master;
go

create database PizzaStoreDb;
go

use PizzaStoreDb;
go

create schema Pizza;
go


create table Pizza.Pizza
(
    PizzaId int not null identity(1,1), --primary key
    CrustId int null,
    SizeId int not null,
    [Name] nvarchar(100) not null,
    constraint PK_PizzaId primary key (PizzaId),
    constraint FK_CrustId foreign key (CrustId) references Pizza.Crust(CrustId),
    constraint FK_SizeId foreign key (SizeId) REFERENCES Pizza.Size(SizeId)
);


create table Pizza.Crust
(
    CrustId int not null identity(1, 1),
    [Name] nvarchar(100) not NULL
    constraint PK_CrustId primary KEY (CrustId)
);

create table Pizza.Size 
(
    SizeId int not null identity(1, 1),
    [Name] nvarchar(100) not null,
    constraint PK_SizeId primary key (SizeId) 
);

create table Pizza.Topping
(
    ToppingId int not null identity(1, 1),
    [Name] nvarchar(100) not null,
    Active bit not null
    constraint PK_ToppingId primary key (ToppingId)
);

create table Pizza.PizzaTopping
(
    PizzaToppingId int not null identity(1, 1),
    PizzaId int not null,
    ToppingId int not null,
    constraint FK_PizzaId foreign key (PizzaId) references Pizza.Pizza(PizzaId),
    constraint FK_ToppingId foreign key (ToppingId) REFERENCES Pizza.Topping(ToppingId)
);
create table Pizza.[User]
(
    Userid int not null IDENTITY(1, 1),
    [Name] nvarchar(100) not null,
);
create table Pizza.[ORDER]
(
    OrderId int not null IDENTITY(1,1),
    PizzaId int not null,
    constraint FK_PizzaId foreign key (PizzaId) references Pizza.Pizza(PizzaId),
)
-- alter table Pizza.SIZE
--     add constraint PK_Size_SizeId primary KEY (SizeId)
-- alter table Pizza.Topping
--     add constraint PK_Topping_ToppingId primary KEY (ToppingId)
-- alter table Pizza.PizzaTopping
--     add constraint PK_PizzaTopping_PizzaToppingId primary KEY (PizzaToppingId)
-- alter table Pizza.PizzaTopping
--     add constraint PK_PizzaTopping_PizzaId PizzaId foreign key references Pizza.Pizza(PizzaId)
-- alter table Pizza.PizzaTopping
--     add constraint PK_PizzaTopping_ToppingId ToppingId foreign key references Pizza.Topping(ToppingId)
drop table Pizza.PizzaTopping;
drop table Pizza.Pizza;
drop table Pizza.Topping;
drop table Pizza.Crust;
drop table Pizza.Size;
