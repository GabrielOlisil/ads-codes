CREATE TABLE `BD2GAB2`;

USE `BD2GAB2`;

CREATE TABLE USUARIO(
id int primary key auto_increment,
nome mediumtext not null,
data_cadastro date,
email mediumtext not null unique
);

CREATE TABLE Assunto(
id int primary key auto_increment,
texto mediumtext
);

CREATE TABLE Disciplina(
id int primary key auto_increment,
nome mediumtext
);

CREATE TABLE Questao(
id int primary key auto_increment,
enunciado mediumtext,
modalidade mediumtext,
nivel mediumtext

);