Create Database TicTacToe
GO

Use TicTacToe
GO

/***************************************************************/
/***                     Creating tables                     ***/
/***************************************************************/

--users
CREATE TABLE users (
    userid INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(255) NOT NULL UNIQUE,
    password NVARCHAR(255) NOT NULL
);

--games
CREATE TABLE tic_tac_toe_games (
    game_id INT PRIMARY KEY IDENTITY(1,1),
    player1_userid INT NOT NULL,
    player2_userid INT NOT NULL,
    moves VARCHAR(27) NOT NULL,
    winner VARCHAR(1),
    timestamp DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (player1_userid) REFERENCES users(userid),
    FOREIGN KEY (player2_userid) REFERENCES users(userid)
);




/***************************************************************/
/***                   Inserting data                        ***/
/***************************************************************/

INSERT INTO users (username, password)
VALUES
    ('user1', 'password1'),
    ('user2', 'password2'),
    ('user3', 'password3'),
    ('user4', 'password4');


INSERT INTO tic_tac_toe_games (player1_userid, player2_userid, moves, winner)
VALUES
    (1, 2, 'O1,X2,O3,X4,O5,X6', 'X'), 
    (3, 4, 'O1,X2,O3,X4,O5,X6,O7,X8', 'O'), 
    (1, 3, 'O1,X2,O3,X4,X5', NULL), 
    (2, 4, 'O1,O2,X3,X4,O5,X6', 'O');
