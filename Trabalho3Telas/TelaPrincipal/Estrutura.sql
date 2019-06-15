CREATE TABLE peixes (
id INT PRIMARY KEY IDENTITY (1,1),
nome VARCHAR(40),
raca VARCHAR(50),
preco DECIMAL(8,2),
quantidade INT
);

SELECT *FROM peixes;

CREATE TABLE colaboradores (
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100),
cpf VARCHAR(14),
salario DECIMAL(8,2),
sexo VARCHAR(20),
cargo VARCHAR(50),
programador BIT
);

SELECT * FROM colaboradores;

CREATE TABLE clientes (
id INT PRIMARY KEY IDENTITY (1,10),
nome VARCHAR(100),
peso DECIMAL(5,2),
altura DECIMAL(3,2),
nome_sujo BIT,
saldo DECIMAL(8,2),
telefone INT,
estado VARCHAR(100),
cidade VARCHAR(100),
bairro VARCHAR(100),
cep INT,
logradouro VARCHAR(100),
numero INT,
complemento TEXT
);

SELECT * FROM clientes;