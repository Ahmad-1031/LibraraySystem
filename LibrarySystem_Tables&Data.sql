-----------Tables Creation----------------
DROP TABLE FINES;
DROP TABLE LOANS;
DROP TABLE MEMBERS;
DROP TABLE BOOKS;
DROP TABLE GENRES;


CREATE TABLE GENRES(
GenreCode CHAR(2),
GenreDesc VARCHAR(30) NOT NULL,
CONSTRAINT pk_genres PRIMARY KEY (GenreCode)
);
COMMIT;

CREATE TABLE BOOKS (
BookID NUMBER,
GenreCode CHAR(2),
BookTitle VARCHAR(50) NOT NULL,
Author VARCHAR(30) NOT NULL,
Description VARCHAR(50) NOT NULL,
Status CHAR(1) DEFAULT 'A',
IsDeleted CHAR(1) DEFAULT 'N',
CONSTRAINT uq_book UNIQUE(BookTitle,Author),
CONSTRAINT pk_books PRIMARY KEY (BookID),
CONSTRAINT fk_genre FOREIGN KEY (GenreCode) REFERENCES Genres(GenreCode)
);
COMMIT;

CREATE TABLE MEMBERS(
MemID NUMBER,
Fname Varchar(25) NOT NULL,
Sname VARCHAR(25) NOT NULL,
Phone VARCHAR(13) NOT NULL,
Email VARCHAR(50) NOT NULL,
IsDeleted CHAR(1) DEFAULT 'N',
CONSTRAINT uq_member UNIQUE(Email),
CONSTRAINT pk_Members PRIMARY KEY(MemID)
);
COMMIT;

CREATE TABLE LOANS(
LoanID NUMBER,
MemID NUMBER,
BookID NUMBER,
StartDate DATE NOT NULL,
DueDate DATE NOT NULL,
ReturnedDate DATE DEFAULT NULL,
CONSTRAINT pk_Loans PRIMARY KEY(LoanID),
CONSTRAINT fk_MemID FOREIGN KEY(MemID) REFERENCES Members(MemID),
CONSTRAINT fk_BookID FOREIGN KEY(BookID) REFERENCES Books(BookID)
);
COMMIT;

CREATE TABLE FINES(
FineID NUMBER,
LoanID NUMBER,
Amount DECIMAL(4,2) NOT NULL,
FineDate DATE NOT NULL,
CONSTRAINT pk_Fines PRIMARY KEY(FineID),
CONSTRAINT fk_LoanID FOREIGN KEY(LoanID) REFERENCES Loans(LoanID)
);
COMMIT;




--------------Genres Data----------------
INSERT INTO GENRES (GENRECODE,GENREDESC)
VALUES ('HR','HORROR');

INSERT INTO GENRES (GENRECODE,GENREDESC)
VALUES ('FN','FANTASY');

INSERT INTO GENRES (GENRECODE,GENREDESC)
VALUES ('SF','SCIENCE FICTION');

INSERT INTO GENRES (GENRECODE,GENREDESC)
VALUES ('MY','MYSTERY');

INSERT INTO GENRES (GENRECODE,GENREDESC)
VALUES ('RM','ROMANCE');

INSERT INTO GENRES (GENRECODE,GENREDESC)
VALUES ('TH','THRILLER');

INSERT INTO GENRES (GENRECODE,GENREDESC)
VALUES ('BI','BIOGRAPHY');

INSERT INTO GENRES (GENRECODE,GENREDESC)
VALUES ('HI','HISTORY');

INSERT INTO GENRES (GENRECODE,GENREDESC)
VALUES ('AD','ADVENTURE');
COMMIT;


----------------Books Data-----------------
INSERT INTO BOOKS VALUES (1, 'HR', 'The Shining', 'Stephen King', 'Haunted hotel horror story', 'A', 'N');
INSERT INTO BOOKS VALUES (2, 'HR', 'IT', 'Stephen King', 'Evil clown terrorizes town', 'A', 'N');
INSERT INTO BOOKS VALUES (3, 'HR', 'Dracula', 'Bram Stoker', 'Classic vampire horror tale', 'A', 'N');
INSERT INTO BOOKS VALUES (4, 'HR', 'Frankenstein', 'Mary Shelley', 'Man creates monster', 'A', 'N');

INSERT INTO BOOKS VALUES (5, 'FN', 'Harry Potter and the Philosopher''s Stone', 'J.K. Rowling', 'Wizard begins journey', 'A', 'N');
INSERT INTO BOOKS VALUES (6, 'FN', 'Harry Potter and the Chamber of Secrets', 'J.K. Rowling', 'Hogwarts mystery continues', 'A', 'N');
INSERT INTO BOOKS VALUES (7, 'FN', 'The Hobbit', 'J.R.R. Tolkien', 'Adventure to reclaim treasure', 'A', 'N');
INSERT INTO BOOKS VALUES (8, 'FN', 'The Fellowship of the Ring', 'J.R.R. Tolkien', 'Start of epic journey', 'A', 'N');
INSERT INTO BOOKS VALUES (9, 'FN', 'A Game of Thrones', 'George R.R. Martin', 'Political fantasy war begins', 'A', 'N');
INSERT INTO BOOKS VALUES (10, 'FN', 'The Name of the Wind', 'Patrick Rothfuss', 'Story of a gifted magician', 'A', 'N');

INSERT INTO BOOKS VALUES (11, 'SF', 'Dune', 'Frank Herbert', 'Desert planet politics', 'A', 'N');
INSERT INTO BOOKS VALUES (12, 'SF', 'The Martian', 'Andy Weir', 'Survival on Mars', 'A', 'N');
INSERT INTO BOOKS VALUES (13, 'SF', '1984', 'George Orwell', 'Dystopian surveillance state', 'A', 'N');
INSERT INTO BOOKS VALUES (14, 'SF', 'Brave New World', 'Aldous Huxley', 'Controlled future society', 'A', 'N');
INSERT INTO BOOKS VALUES (15, 'SF', 'Foundation', 'Isaac Asimov', 'Rise and fall of empire', 'A', 'N');

INSERT INTO BOOKS VALUES (16, 'MY', 'The Da Vinci Code', 'Dan Brown', 'Religious mystery thriller', 'A', 'N');
INSERT INTO BOOKS VALUES (17, 'MY', 'Gone Girl', 'Gillian Flynn', 'Missing wife mystery', 'A', 'N');
INSERT INTO BOOKS VALUES (18, 'MY', 'Sherlock Holmes: Study in Scarlet', 'Arthur Conan Doyle', 'First Sherlock case', 'A', 'N');
INSERT INTO BOOKS VALUES (19, 'MY', 'The Girl with the Dragon Tattoo', 'Stieg Larsson', 'Dark investigative mystery', 'A', 'N');

INSERT INTO BOOKS VALUES (20, 'TH', 'The Girl on the Train', 'Paula Hawkins', 'Psychological thriller journey', 'A', 'N');
INSERT INTO BOOKS VALUES (21, 'TH', 'Gone Girl 2', 'Gillian Flynn', 'Marriage thriller', 'A', 'N');
INSERT INTO BOOKS VALUES (22, 'TH', 'Shutter Island', 'Dennis Lehane', 'Mental asylum mystery', 'A', 'N');
INSERT INTO BOOKS VALUES (23, 'TH', 'The Silence of the Lambs', 'Thomas Harris', 'FBI hunts serial killer', 'A', 'N');

INSERT INTO BOOKS VALUES (24, 'RM', 'Pride and Prejudice', 'Jane Austen', 'Classic romance story', 'A', 'N');
INSERT INTO BOOKS VALUES (25, 'RM', 'Jane Eyre', 'Charlotte Bronte', 'Love and independence', 'A', 'N');
INSERT INTO BOOKS VALUES (26, 'RM', 'Me Before You', 'Jojo Moyes', 'Emotional love story', 'A', 'N');
INSERT INTO BOOKS VALUES (27, 'RM', 'The Notebook', 'Nicholas Sparks', 'Romantic life story', 'A', 'N');

INSERT INTO BOOKS VALUES (28, 'BI', 'Steve Jobs', 'Walter Isaacson', 'Life of Apple founder', 'A', 'N');
INSERT INTO BOOKS VALUES (29, 'BI', 'Becoming', 'Michelle Obama', 'Memoir of First Lady', 'A', 'N');
INSERT INTO BOOKS VALUES (30, 'BI', 'Einstein: His Life and Universe', 'Walter Isaacson', 'Biography of Einstein', 'A', 'N');

INSERT INTO BOOKS VALUES (31, 'HI', 'Sapiens', 'Yuval Noah Harari', 'History of humankind', 'A', 'N');
INSERT INTO BOOKS VALUES (32, 'HI', 'Guns, Germs, and Steel', 'Jared Diamond', 'History of civilizations', 'A', 'N');
INSERT INTO BOOKS VALUES (33, 'HI', 'The Diary of a Young Girl', 'Anne Frank', 'WW2 diary', 'A', 'N');

INSERT INTO BOOKS VALUES (34, 'AD', 'Life of Pi', 'Yann Martel', 'Survival at sea with tiger', 'A', 'N');
INSERT INTO BOOKS VALUES (35, 'AD', 'Treasure Island', 'Robert Louis Stevenson', 'Pirate adventure', 'A', 'N');
INSERT INTO BOOKS VALUES (36, 'AD', 'The Call of the Wild', 'Jack London', 'Dog survival story', 'A', 'N');

INSERT INTO BOOKS VALUES (37, 'FN', 'Circe', 'Madeline Miller', 'Greek mythology retold', 'A', 'N');
INSERT INTO BOOKS VALUES (38, 'FN', 'The Song of Achilles', 'Madeline Miller', 'Mythological romance', 'A', 'N');
INSERT INTO BOOKS VALUES (39, 'FN', 'Percy Jackson: Lightning Thief', 'Rick Riordan', 'Teen demigod adventure', 'A', 'N');

INSERT INTO BOOKS VALUES (40, 'SF', 'Project Hail Mary', 'Andy Weir', 'Space survival mission', 'A', 'N');
INSERT INTO BOOKS VALUES (41, 'SF', 'Ender''s Game', 'Orson Scott Card', 'Child military genius', 'A', 'N');
INSERT INTO BOOKS VALUES (42, 'SF', 'Neuromancer', 'William Gibson', 'Cyberpunk AI story', 'A', 'N');

INSERT INTO BOOKS VALUES (43, 'MY', 'Angels and Demons', 'Dan Brown', 'Religious conspiracy thriller', 'A', 'N');
INSERT INTO BOOKS VALUES (44, 'TH', 'Before I Go to Sleep', 'S.J. Watson', 'Memory loss thriller', 'A', 'N');

INSERT INTO BOOKS VALUES (45, 'RM', 'Outlander', 'Diana Gabaldon', 'Time travel romance', 'A', 'N');
INSERT INTO BOOKS VALUES (46, 'RM', 'Twilight', 'Stephenie Meyer', 'Vampire romance', 'A', 'N');

INSERT INTO BOOKS VALUES (47, 'HR', 'The Exorcist', 'William Peter Blatty', 'Demonic possession horror', 'A', 'N');
INSERT INTO BOOKS VALUES (48, 'HR', 'Pet Sematary', 'Stephen King', 'Cursed burial ground', 'A', 'N');

INSERT INTO BOOKS VALUES (49, 'SF', 'Snow Crash', 'Neal Stephenson', 'Virtual reality cyber world', 'A', 'N');

INSERT INTO BOOKS VALUES (50, 'AD', 'The Three Musketeers', 'Alexandre Dumas', 'Swashbuckling adventure', 'A', 'N');

COMMIT;

-------------------------Members Data------------------
INSERT INTO MEMBERS VALUES (1, 'Liam', 'Murphy', '0851234567', 'liam.murphy@gmail.com', 'N');
INSERT INTO MEMBERS VALUES (2, 'Emma', 'O''Connor', '0862345678', 'emma.oconnor@gmail.com', 'N');
INSERT INTO MEMBERS VALUES (3, 'Jack', 'Byrne', '0873456789', 'jack.byrne@gmail.com', 'N');
INSERT INTO MEMBERS VALUES (4, 'Sophie', 'Kelly', '0834567890', 'sophie.kelly@gmail.com', 'N');
INSERT INTO MEMBERS VALUES (5, 'Noah', 'Walsh', '0855678901', 'noah.walsh@gmail.com', 'N');

INSERT INTO MEMBERS VALUES (6, 'Ava', 'Ryan', '0866789012', 'ava.ryan@gmail.com', 'N');
INSERT INTO MEMBERS VALUES (7, 'Daniel', 'O''Sullivan', '0877890123', 'daniel.osullivan@gmail.com', 'N');
INSERT INTO MEMBERS VALUES (8, 'Grace', 'Healy', '0838901234', 'grace.healy@gmail.com', 'N');
INSERT INTO MEMBERS VALUES (9, 'James', 'Fitzgerald', '0859012345', 'james.fitzgerald@gmail.com', 'N');
INSERT INTO MEMBERS VALUES (10, 'Chloe', 'Doyle', '0860123456', 'chloe.doyle@gmail.com', 'N');

INSERT INTO MEMBERS VALUES (11, 'Ethan', 'Kennedy', '0871122334', 'ethan.kennedy@gmail.com', 'N');
INSERT INTO MEMBERS VALUES (12, 'Mia', 'Daly', '0832233445', 'mia.daly@gmail.com', 'N');
INSERT INTO MEMBERS VALUES (13, 'Ryan', 'Quinn', '0853344556', 'ryan.quinn@gmail.com', 'N');
INSERT INTO MEMBERS VALUES (14, 'Ella', 'Brennan', '0864455667', 'ella.brennan@gmail.com', 'N');
INSERT INTO MEMBERS VALUES (15, 'Luke', 'Murray', '0875566778', 'luke.murray@gmail.com', 'N');

INSERT INTO MEMBERS VALUES (16, 'Hannah', 'Cullen', '0836677889', 'hannah.cullen@gmail.com', 'N');
INSERT INTO MEMBERS VALUES (17, 'Ben', 'Moore', '0857788990', 'ben.moore@gmail.com', 'N');
INSERT INTO MEMBERS VALUES (18, 'Olivia', 'Reid', '0868899001', 'olivia.reid@gmail.com', 'N');
INSERT INTO MEMBERS VALUES (19, 'Adam', 'Foley', '0879900112', 'adam.foley@gmail.com', 'N');
INSERT INTO MEMBERS VALUES (20, 'Lucy', 'Hughes', '0831011121', 'lucy.hughes@gmail.com', 'N');
COMMIT;



--------------------Loans Data----------------
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (1, 1, 3, DATE '2026-01-02', DATE '2026-01-16', DATE '2026-01-14');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (2, 2, 7, DATE '2026-01-03', DATE '2026-01-17', DATE '2026-01-20');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (3, 3, 12, DATE '2026-01-05', DATE '2026-01-19', DATE '2026-01-18');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (4, 4, 15, DATE '2026-01-06', DATE '2026-01-20', DATE '2026-01-25');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (5, 5, 21, DATE '2026-01-07', DATE '2026-01-21', DATE '2026-01-19');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (6, 6, 28, DATE '2026-01-08', DATE '2026-01-22', DATE '2026-01-28');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (7, 7, 33, DATE '2026-01-09', DATE '2026-01-23', DATE '2026-01-22');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (8, 8, 40, DATE '2026-01-10', DATE '2026-01-24', DATE '2026-01-30');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (9, 9, 45, DATE '2026-01-12', DATE '2026-01-26', DATE '2026-01-25');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (10, 10, 50, DATE '2026-01-13', DATE '2026-01-27', DATE '2026-02-01');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (11, 11, 2, DATE '2026-01-14', DATE '2026-01-28', DATE '2026-01-27');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (12, 12, 8, DATE '2026-01-15', DATE '2026-01-29', DATE '2026-02-02');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (13, 13, 14, DATE '2026-01-16', DATE '2026-01-30', DATE '2026-01-29');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (14, 14, 19, DATE '2026-01-17', DATE '2026-01-31', DATE '2026-02-04');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (15, 15, 25, DATE '2026-01-19', DATE '2026-02-02', DATE '2026-02-01');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (16, 16, 31, DATE '2026-01-20', DATE '2026-02-03', DATE '2026-02-06');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (17, 17, 37, DATE '2026-01-21', DATE '2026-02-04', DATE '2026-02-03');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (18, 18, 43, DATE '2026-01-22', DATE '2026-02-05', DATE '2026-02-08');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (19, 19, 48, DATE '2026-01-23', DATE '2026-02-06', DATE '2026-02-05');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (20, 20, 5, DATE '2026-01-24', DATE '2026-02-07', DATE '2026-02-10');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (21, 1, 10, DATE '2026-02-02', DATE '2026-02-16', DATE '2026-02-15');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (22, 2, 16, DATE '2026-02-03', DATE '2026-02-17', DATE '2026-02-20');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (23, 3, 22, DATE '2026-02-04', DATE '2026-02-18', DATE '2026-02-17');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (24, 4, 27, DATE '2026-02-05', DATE '2026-02-19', DATE '2026-02-22');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (25, 5, 34, DATE '2026-02-06', DATE '2026-02-20', DATE '2026-02-19');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (26, 6, 39, DATE '2026-02-07', DATE '2026-02-21', DATE '2026-02-24');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (27, 7, 44, DATE '2026-02-09', DATE '2026-02-23', DATE '2026-02-22');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (28, 8, 49, DATE '2026-02-10', DATE '2026-02-24', DATE '2026-02-27');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (29, 9, 6, DATE '2026-02-11', DATE '2026-02-25', DATE '2026-02-24');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (30, 10, 11, DATE '2026-02-12', DATE '2026-02-26', DATE '2026-03-01');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (31, 11, 17, DATE '2026-02-13', DATE '2026-02-27', DATE '2026-02-26');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (32, 12, 23, DATE '2026-02-14', DATE '2026-02-28', DATE '2026-03-03');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (33, 13, 29, DATE '2026-02-16', DATE '2026-03-02', DATE '2026-03-01');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (34, 14, 35, DATE '2026-02-17', DATE '2026-03-03', DATE '2026-03-06');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (35, 15, 41, DATE '2026-02-18', DATE '2026-03-04', DATE '2026-03-03');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (36, 16, 46, DATE '2026-02-19', DATE '2026-03-05', DATE '2026-03-08');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (37, 17, 1, DATE '2026-02-20', DATE '2026-03-06', DATE '2026-03-05');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (38, 18, 9, DATE '2026-02-23', DATE '2026-03-09', DATE '2026-03-12');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (39, 19, 13, DATE '2026-02-24', DATE '2026-03-10', DATE '2026-03-09');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (40, 20, 18, DATE '2026-02-25', DATE '2026-03-11', DATE '2026-03-14');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (41, 1, 24, DATE '2026-03-02', DATE '2026-03-16', DATE '2026-03-15');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (42, 2, 30, DATE '2026-03-03', DATE '2026-03-17', DATE '2026-03-20');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (43, 3, 36, DATE '2026-03-04', DATE '2026-03-18', DATE '2026-03-17');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (44, 4, 42, DATE '2026-03-05', DATE '2026-03-19', DATE '2026-03-22');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (45, 5, 47, DATE '2026-03-06', DATE '2026-03-20', DATE '2026-03-19');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (46, 6, 4, DATE '2026-03-09', DATE '2026-03-23', DATE '2026-03-26');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (47, 7, 20, DATE '2026-03-10', DATE '2026-03-24', DATE '2026-03-23');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (48, 8, 26, DATE '2026-03-11', DATE '2026-03-25', DATE '2026-03-28');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (49, 9, 32, DATE '2026-03-12', DATE '2026-03-26', DATE '2026-03-25');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (50, 10, 38, DATE '2026-03-13', DATE '2026-03-27', DATE '2026-03-30');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (51, 11, 4, DATE '2026-04-01', DATE '2026-04-15', DATE '2026-04-14');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (52, 12, 9, DATE '2026-04-02', DATE '2026-04-16', DATE '2026-04-19');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (53, 13, 15, DATE '2026-04-03', DATE '2026-04-17', DATE '2026-04-16');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (54, 14, 21, DATE '2026-04-06', DATE '2026-04-20', DATE '2026-04-23');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (55, 15, 27, DATE '2026-04-07', DATE '2026-04-21', DATE '2026-04-20');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (56, 16, 33, DATE '2026-04-08', DATE '2026-04-22', DATE '2026-04-25');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (57, 17, 39, DATE '2026-04-09', DATE '2026-04-23', DATE '2026-04-22');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (58, 18, 45, DATE '2026-04-10', DATE '2026-04-24', DATE '2026-04-27');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (59, 19, 50, DATE '2026-04-13', DATE '2026-04-27', DATE '2026-04-26');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (60, 20, 6, DATE '2026-04-14', DATE '2026-04-28', DATE '2026-05-01');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (61, 1, 11, DATE '2026-05-04', DATE '2026-05-18', DATE '2026-05-17');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (62, 2, 17, DATE '2026-05-05', DATE '2026-05-19', DATE '2026-05-22');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (63, 3, 23, DATE '2026-05-06', DATE '2026-05-20', DATE '2026-05-19');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (64, 4, 29, DATE '2026-05-07', DATE '2026-05-21', DATE '2026-05-24');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (65, 5, 35, DATE '2026-05-08', DATE '2026-05-22', DATE '2026-05-21');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (66, 6, 41, DATE '2026-05-11', DATE '2026-05-25', DATE '2026-05-28');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (67, 7, 46, DATE '2026-05-12', DATE '2026-05-26', DATE '2026-05-25');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (68, 8, 2, DATE '2026-05-13', DATE '2026-05-27', DATE '2026-05-30');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (69, 9, 8, DATE '2026-05-14', DATE '2026-05-28', DATE '2026-05-27');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (70, 10, 14, DATE '2026-05-15', DATE '2026-05-29', DATE '2026-06-01');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (71, 11, 20, DATE '2026-06-01', DATE '2026-06-15', DATE '2026-06-14');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (72, 12, 26, DATE '2026-06-02', DATE '2026-06-16', DATE '2026-06-19');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (73, 13, 32, DATE '2026-06-03', DATE '2026-06-17', DATE '2026-06-16');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (74, 14, 38, DATE '2026-06-04', DATE '2026-06-18', DATE '2026-06-21');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (75, 15, 44, DATE '2026-06-05', DATE '2026-06-19', DATE '2026-06-18');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (76, 16, 49, DATE '2026-06-08', DATE '2026-06-22', DATE '2026-06-25');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (77, 17, 5, DATE '2026-06-09', DATE '2026-06-23', DATE '2026-06-22');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (78, 18, 10, DATE '2026-06-10', DATE '2026-06-24', DATE '2026-06-27');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (79, 19, 16, DATE '2026-06-11', DATE '2026-06-25', DATE '2026-06-24');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (80, 20, 22, DATE '2026-06-12', DATE '2026-06-26', DATE '2026-06-29');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (81, 1, 28, DATE '2026-07-01', DATE '2026-07-15', DATE '2026-07-14');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (82, 2, 34, DATE '2026-07-02', DATE '2026-07-16', DATE '2026-07-19');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (83, 3, 40, DATE '2026-07-03', DATE '2026-07-17', DATE '2026-07-16');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (84, 4, 47, DATE '2026-07-06', DATE '2026-07-20', DATE '2026-07-23');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (85, 5, 3, DATE '2026-07-07', DATE '2026-07-21', DATE '2026-07-20');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (86, 6, 13, DATE '2026-08-03', DATE '2026-08-17', DATE '2026-08-20');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (87, 7, 19, DATE '2026-08-04', DATE '2026-08-18', DATE '2026-08-17');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (88, 8, 25, DATE '2026-08-05', DATE '2026-08-19', DATE '2026-08-22');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (89, 9, 31, DATE '2026-09-01', DATE '2026-09-15', DATE '2026-09-14');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (90, 10, 37, DATE '2026-09-02', DATE '2026-09-16', DATE '2026-09-19');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (91, 11, 43, DATE '2026-09-03', DATE '2026-09-17', DATE '2026-09-16');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (92, 12, 48, DATE '2026-09-04', DATE '2026-09-18', DATE '2026-09-21');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (93, 13, 7, DATE '2026-10-01', DATE '2026-10-15', DATE '2026-10-14');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (94, 14, 12, DATE '2026-10-02', DATE '2026-10-16', DATE '2026-10-19');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (95, 15, 18, DATE '2026-10-05', DATE '2026-10-19', DATE '2026-10-18');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (96, 16, 24, DATE '2026-11-02', DATE '2026-11-16', DATE '2026-11-19');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (97, 17, 30, DATE '2026-11-03', DATE '2026-11-17', DATE '2026-11-16');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (98, 18, 36, DATE '2026-11-04', DATE '2026-11-18', DATE '2026-11-21');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (99, 19, 42, DATE '2026-12-01', DATE '2026-12-15', DATE '2026-12-14');
INSERT INTO Loans (LoanID, MemID, BookID, StartDate, DueDate, ReturnedDate) VALUES (100, 20, 48, DATE '2026-12-02', DATE '2026-12-16', DATE '2026-12-19');
COMMIT;


------------------------Fines Data---------------------
-- JAN (12 entries)
INSERT INTO Fines VALUES (1, 1, 10, TO_DATE('03-01-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (2, 2, 10, TO_DATE('07-01-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (3, 3, 10, TO_DATE('12-01-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (4, 4, 10, TO_DATE('18-01-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (5, 5, 10, TO_DATE('25-01-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (6, 6, 10, TO_DATE('29-01-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (7, 7, 10, TO_DATE('10-01-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (8, 8, 10, TO_DATE('15-01-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (9, 9, 10, TO_DATE('21-01-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (10, 10, 10, TO_DATE('28-01-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (11, 11, 10, TO_DATE('05-01-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (12, 12, 10, TO_DATE('17-01-2026','DD-MM-YYYY'));

-- FEB (5 entries)
INSERT INTO Fines VALUES (13, 13, 10, TO_DATE('02-02-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (14, 14, 10, TO_DATE('09-02-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (15, 15, 10, TO_DATE('14-02-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (16, 16, 10, TO_DATE('20-02-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (17, 17, 10, TO_DATE('27-02-2026','DD-MM-YYYY'));

-- MAR (8 entries)
INSERT INTO Fines VALUES (18, 18, 10, TO_DATE('03-03-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (19, 19, 10, TO_DATE('06-03-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (20, 20, 10, TO_DATE('11-03-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (21, 21, 10, TO_DATE('15-03-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (22, 22, 10, TO_DATE('19-03-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (23, 23, 10, TO_DATE('24-03-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (24, 24, 10, TO_DATE('28-03-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (25, 25, 10, TO_DATE('30-03-2026','DD-MM-YYYY'));

-- APR (10 entries)
INSERT INTO Fines VALUES (26, 26, 10, TO_DATE('02-04-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (27, 27, 10, TO_DATE('05-04-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (28, 28, 10, TO_DATE('08-04-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (29, 29, 10, TO_DATE('11-04-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (30, 30, 10, TO_DATE('14-04-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (31, 31, 10, TO_DATE('17-04-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (32, 32, 10, TO_DATE('20-04-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (33, 33, 10, TO_DATE('23-04-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (34, 34, 10, TO_DATE('26-04-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (35, 35, 10, TO_DATE('29-04-2026','DD-MM-YYYY'));

-- MAY (6 entries)
INSERT INTO Fines VALUES (36, 36, 10, TO_DATE('03-05-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (37, 37, 10, TO_DATE('07-05-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (38, 38, 10, TO_DATE('12-05-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (39, 39, 10, TO_DATE('18-05-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (40, 40, 10, TO_DATE('24-05-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (41, 41, 10, TO_DATE('30-05-2026','DD-MM-YYYY'));

-- JUN (4 entries)
INSERT INTO Fines VALUES (42, 42, 10, TO_DATE('05-06-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (43, 43, 10, TO_DATE('11-06-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (44, 44, 10, TO_DATE('18-06-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (45, 45, 10, TO_DATE('27-06-2026','DD-MM-YYYY'));

-- JUL (9 entries)
INSERT INTO Fines VALUES (46, 46, 10, TO_DATE('02-07-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (47, 47, 10, TO_DATE('05-07-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (48, 48, 10, TO_DATE('09-07-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (49, 49, 10, TO_DATE('13-07-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (50, 50, 10, TO_DATE('16-07-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (51, 51, 10, TO_DATE('19-07-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (52, 52, 10, TO_DATE('22-07-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (53, 53, 10, TO_DATE('26-07-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (54, 54, 10, TO_DATE('30-07-2026','DD-MM-YYYY'));

-- AUG (3 entries)
INSERT INTO Fines VALUES (55, 55, 10, TO_DATE('04-08-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (56, 56, 10, TO_DATE('15-08-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (57, 57, 10, TO_DATE('28-08-2026','DD-MM-YYYY'));

-- SEP (7 entries)
INSERT INTO Fines VALUES (58, 58, 10, TO_DATE('02-09-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (59, 59, 10, TO_DATE('06-09-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (60, 60, 10, TO_DATE('10-09-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (61, 61, 10, TO_DATE('14-09-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (62, 62, 10, TO_DATE('18-09-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (63, 63, 10, TO_DATE('22-09-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (64, 64, 10, TO_DATE('29-09-2026','DD-MM-YYYY'));

-- OCT (6 entries)
INSERT INTO Fines VALUES (65, 65, 10, TO_DATE('03-10-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (66, 66, 10, TO_DATE('08-10-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (67, 67, 10, TO_DATE('13-10-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (68, 68, 10, TO_DATE('17-10-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (69, 69, 10, TO_DATE('24-10-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (70, 70, 10, TO_DATE('30-10-2026','DD-MM-YYYY'));

-- NOV (5 entries)
INSERT INTO Fines VALUES (71, 71, 10, TO_DATE('02-11-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (72, 72, 10, TO_DATE('07-11-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (73, 73, 10, TO_DATE('15-11-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (74, 74, 10, TO_DATE('21-11-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (75, 75, 10, TO_DATE('29-11-2026','DD-MM-YYYY'));

-- DEC (5 entries)
INSERT INTO Fines VALUES (76, 76, 10, TO_DATE('03-12-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (77, 77, 10, TO_DATE('08-12-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (78, 78, 10, TO_DATE('14-12-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (79, 79, 10, TO_DATE('20-12-2026','DD-MM-YYYY'));
INSERT INTO Fines VALUES (80, 80, 10, TO_DATE('28-12-2026','DD-MM-YYYY'));
COMMIT;






