# Welcome to ZurroMicroservice

ZurroMicroservice is a service that is responsible for managing user data efficiently.

## Requirements

ZurroMicroservice uses a [MySQL](https://dev.mysql.com/downloads/installer/) and [MySQL Workbench](https://dev.mysql.com/downloads/workbench/) database, to be able to connect you must change the values ​​of "ConnectionStrings/DefaultConnection" in the [appsettings.json](https://github.com/kevinzurro/ZurroMicroservice/blob/main/ZurroService/appsettings.json) file.
You must change the values ​​of port, database and password to be able to connect correctly.

## Functions

 * Create new user.
 * Update user state.
 * Delete user.
 * List all active user.

### User Model

User structured data are follows:
 * ID = Unique identifier for the user.
 * Name = User's full name.
 * Birthdate = User's date of birth.
 * Active = Indicating whether the user is active.
