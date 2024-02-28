CREATE DATABASE `BD2GAB1`;
USE `BD2GAB1`;

CREATE TABLE `Aluno`(
id int primary key auto_increment,
nome varchar(80) not null,
email varchar(50) not null,
telefone varchar(80),
data_nascimento date not null,
ativo boolean default true
);


alter table `Aluno` add cpf varchar(15) not null unique;
alter table `Aluno` drop cpf;

show columns from `aluno`;




alter table `Aluno` add cpf varchar(15) not null unique after id;


RENAME TABLE `Aluno` TO `Alunos`;


desc `Alunos`;


create table `departamento`(
id int primary key auto_increment,
nome varchar(50)
);

create table `funcionario`(
id int primary key auto_increment,
nome varchar(50),
id_departamento_fk int,
foreign key (id_departamento_fk) references departamento(id)

);
-- drop database `BD2GAB1`;