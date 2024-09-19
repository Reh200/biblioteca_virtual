-- Criação do banco de dados
CREATE DATABASE BibliotecaDB;
USE BibliotecaDB;

-- Tabela para Autores
CREATE TABLE Autores (
    id_autor INT AUTO_INCREMENT PRIMARY KEY,
    nome_autor VARCHAR(255) NOT NULL
);

-- Tabela para Gêneros
CREATE TABLE Generos (
    id_genero INT AUTO_INCREMENT PRIMARY KEY,
    nome_genero VARCHAR(100) NOT NULL
);

-- Tabela para Livros
CREATE TABLE Livros (
    id_livro INT AUTO_INCREMENT PRIMARY KEY,
    titulo VARCHAR(255) NOT NULL,
    sinopse TEXT NOT NULL,
    id_autor INT,
    id_genero INT,
    FOREIGN KEY (id_autor) REFERENCES Autores(id_autor),
    FOREIGN KEY (id_genero) REFERENCES Generos(id_genero)
);

-- Inserção de dados na tabela Autores
INSERT INTO Autores (nome_autor) VALUES 
('Mark Miller'),
('Guilherme Pintto'),
('Ichiro Kishimi'),
('Fumitake Koga'),
('Casey McQuiston'),
('Lovely Loser'),
('Bram Stoker'),
('Ique Carvalho'),
('Igor Pires');

-- Inserção de dados na tabela Generos
INSERT INTO Generos (nome_genero) VALUES 
('Mistério'),
('Reflexão'),
('Filosofia'),
('Romance'),
('Terror'),
('Drama'),
('Poesia');

-- Inserção de dados na tabela Livros
INSERT INTO Livros (titulo, sinopse, id_autor, id_genero) VALUES
('Ninguém Vai Te Ouvir Gritar', 'A Academia Masters é um dos internatos mais prestigiados dos Estados Unidos. Escondido em uma ilha na costa da Flórida e cercado por muros impenetráveis...', 1, 1),
('O Óbvio Também Precisa Ser Dito', 'Do mesmo autor do fenômeno Seja o amor da sua vida Estamos quase sempre ocupados com o desejo de não ficarmos tão ocupados no futuro...', 2, 2),
('A Coragem de Não Agradar', 'Na periferia de uma cidade milenar vivia um filósofo que ensinava que o mundo era simples e que a felicidade estava ao alcance de todos...', 3, 3),
('Vermelho, Branco e Sangue Azul', 'O que pode acontecer quando o filho da presidenta dos Estados Unidos se apaixona pelo príncipe da Inglaterra?', 4, 4),
('Jogos de Conquista', 'Evan Sutton, capitão do time de hóquei da faculdade, está focado em um único objetivo: alcançar o sucesso na sua carreira...', 5, 4),
('Drácula', 'Drácula é um ícone da literatura de terror que, por meio de uma narrativa epistolar composta de cartas, diários, e recortes de notícias...', 7, 5),
('Não Deixe Pra Ser Feliz Depois', 'Aproveite os pequenos momentos de alegria. São eles que tornam a vida bonita. Não deixe para ser feliz depois é um mergulho profundo na força do que é a própria vida...', 8, 6),
('Todas as Coisas Que Eu Te Escreveria se Pudesse', 'Em Todas as coisas que eu te escreveria se pudesse, Igor fala sobre amor, amar e deixar ir, ser intenso e abraçar a sua intensidade...', 9, 7);
