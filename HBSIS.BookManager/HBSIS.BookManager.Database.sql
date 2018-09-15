use DB_A18C40_gabriel

/*DROP TABLE Book;*/

/*DROP TABLE Author;*/

CREATE TABLE Author (
    AuthorId INT NOT NULL,
    Name VARCHAR(100) NOT NULL,
    Age INT NOT NULL

	PRIMARY KEY(AuthorId)
);

INSERT INTO Author (AuthorId, Name, Age) VALUES
(1, 'Gabriel Augusto Silva e Silva', 19);

CREATE TABLE Book (
    BookId INT NOT NULL,
    Name VARCHAR(100) NOT NULL,
    Price MONEY,
	Quantity INT,
	AuthorId INT NOT NULL

    PRIMARY KEY (BookId),
    FOREIGN KEY (AuthorId) REFERENCES Author(AuthorId)
);

INSERT INTO Book (BookId, Name, Price, Quantity, AuthorId) VALUES
(1, 'As crônicas de Narnia - Livro Um', 10.00, 10, 1),
(2, 'Percy Jackson e o Ladrão de Raios', 17.50, 13, 1),
(3, 'Uma Breve História do Tempo', 22.99, 24, 1)


