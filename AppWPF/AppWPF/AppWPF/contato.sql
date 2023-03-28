CREATE DATABASE app_contato_bd;
USE app_contato_bd;

CREATE TABLE contato (
id_con INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
data_nasc_con date null,
nome_con varchar(200) ,
email_con varchar(200),
telefone_con varchar(50),
sexo_con varchar(30)
);

insert into contato (id_con, data_nasc_con, nome_con, email_con, telefone_con, sexo_con) values (1, '2022-11-20', 'Alwyn Mackelworth', 'amackelworth0@nsw.gov.au', '860-482-5543', 'Male');
insert into contato (id_con, data_nasc_con, nome_con, email_con, telefone_con, sexo_con) values (2, '2022-09-06', 'Enrique Peever', 'epeever1@ask.com', '577-377-2862', 'Male');
insert into contato (id_con, data_nasc_con, nome_con, email_con, telefone_con, sexo_con) values (3, '2022-03-19', 'Kip Terbruggen', 'kterbruggen2@list-manage.com', '703-361-0119', 'Female');
insert into contato (id_con, data_nasc_con, nome_con, email_con, telefone_con, sexo_con) values (4, '2023-01-14', 'Sonny Kneale', 'skneale3@vimeo.com', '896-891-4888', 'Female');
insert into contato (id_con, data_nasc_con, nome_con, email_con, telefone_con, sexo_con) values (5, '2023-02-07', 'Zacherie Iannini', 'ziannini4@redcross.org', '457-928-1582', 'Male');
insert into contato (id_con, data_nasc_con, nome_con, email_con, telefone_con, sexo_con) values (6, '2023-02-09', 'Michell Dagless', 'mdagless5@yahoo.co.jp', '447-311-6554', 'Female');
insert into contato (id_con, data_nasc_con, nome_con, email_con, telefone_con, sexo_con) values (7, '2023-02-09', 'Hyacinth Pallesen', 'hpallesen6@youtube.com', '105-830-4560', 'Female');
insert into contato (id_con, data_nasc_con, nome_con, email_con, telefone_con, sexo_con) values (8, '2022-09-15', 'Carla Jillitt', 'cjillitt7@youtu.be', '541-319-6448', 'Female');
insert into contato (id_con, data_nasc_con, nome_con, email_con, telefone_con, sexo_con) values (9, '2022-11-02', 'Zebulen Arnholtz', 'zarnholtz8@chronoengine.com', '652-287-2423', 'Male');
insert into contato (id_con, data_nasc_con, nome_con, email_con, telefone_con, sexo_con) values (10, '2022-09-13', 'Delphine Bahls', 'dbahls9@freewebs.com', '440-360-8810', 'Female');

SELECT * from contato;