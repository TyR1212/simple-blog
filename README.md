# simple-blog
This is a WinForms application that uses a local database to allow a user to log in or create an account. Then the user can post a message on a message board and see posts by other users.

The local database is a Microsoft Access file named: "BlogDB.accdb". It must be located in the '~\BlogAndDatabase\bin\Debug' directory. This project uses the Dapper package to make sending SQL queries simple.