create table Book
(BookId int primary key,
BookName varchar(50) not null,
Price int,
Author varchar(30),
language varchar(20),
ReleaseDate date
)

-- Insert values into the Book table
INSERT INTO Book (BookId, BookName, Price, Author, language, ReleaseDate) VALUES
(1, 'To Kill a Mockingbird', 18, 'Harper Lee', 'English', '1960-07-11'),
(2, '1984', 15, 'George Orwell', 'English', '1949-06-08'),
(3, 'Pride and Prejudice', 10, 'Jane Austen', 'English', '1813-01-28'),
(4, 'The Great Gatsby', 20, 'F. Scott Fitzgerald', 'English', '1925-04-10'),
(5, 'Moby Dick', 25, 'Herman Melville', 'English', '1851-10-18'),
(6, 'War and Peace', 30, 'Leo Tolstoy', 'Russian', '1869-01-01'),
(7, 'The Odyssey', 22, 'Homer', 'Greek', '1800-01-01'),
(8, 'Crime and Punishment', 18, 'Fyodor Dostoevsky', 'Russian', '1866-01-01'),
(9, 'The Catcher in the Rye', 15, 'J.D. Salinger', 'English', '1951-07-16'),
(10, 'The Hobbit', 20, 'J.R.R. Tolkien', 'English', '1937-09-21'),
(11, 'One Hundred Years of Solitude', 17, 'Gabriel Garcia Marquez', 'Spanish', '1967-05-30'),
(12, 'The Divine Comedy', 25, 'Dante Alighieri', 'Italian', '1320-01-01'),
(13, 'Don Quixote', 27, 'Miguel de Cervantes', 'Spanish', '1605-01-16'),
(14, 'Brave New World', 19, 'Aldous Huxley', 'English', '1932-08-31'),
(15, 'The Brothers Karamazov', 21, 'Fyodor Dostoevsky', 'Russian', '1880-01-01');

