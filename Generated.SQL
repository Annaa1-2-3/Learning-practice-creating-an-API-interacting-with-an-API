/*
Created: 05.02.2024
Modified: 05.02.2024
Model: Schema
Database: MS SQL Server 2019
*/


-- Create tables section -------------------------------------------------

-- Table User

CREATE TABLE [User]
(
 user_id Int NOT NULL,
 name Varchar(150) NOT NULL,
 last_name Varchar(150) NOT NULL,
 email Varchar(200) NOT NULL,
 password Varchar(200) NOT NULL,
 registration_date Datetime NOT NULL,
 user_deleted Bit NOT NULL
)
go
-- Add keys for table User
ALTER TABLE [User] ADD CONSTRAINT [Unique_Identifier1] PRIMARY KEY (user_id)
go
-- Table Records
CREATE TABLE [Records]
(
 record_id Int NOT NULL,
 user_id Int NOT NULL,
 title Varchar(150) NOT NULL,
 description Varchar(400) NOT NULL,
 category_id Int NOT NULL,
 creation_date Datetime NOT NULL,
 deletion_date Datetime NULL,
 records_deleted Bit NOT NULL,
 user_deleted Int NULL
)
go
-- Add keys for table Records
ALTER TABLE [Records] ADD CONSTRAINT [Unique_Identifier4] PRIMARY KEY (record_id)
go
-- Table Category
CREATE TABLE [Category]
(
 category_id Int NOT NULL,
 name Varchar(100) NOT NULL
)
go
-- Add keys for table Category
ALTER TABLE [Category] ADD CONSTRAINT [Unique_Identifier5] PRIMARY KEY (category_id)
go
-- Table Actions
CREATE TABLE [Actions]
(
 Attribute1 Int NOT NULL,
 Attribute2 Int NOT NULL,
 actions_id Int NOT NULL,
 action_type Varchar(155) NOT NULL,
 action_date Datetime NOT NULL
)
go
-- Create indexes for table Actions
CREATE INDEX [IX_Actions] ON [Actions] (actions_id)
go
-- Add keys for table Actions
ALTER TABLE [Actions] ADD CONSTRAINT [Unique_Identifier7] PRIMARY KEY (Attribute1, actions_id)
go
-- Table RecordsCategory
CREATE TABLE [RecordsCategory]
(
 record_id Int NOT NULL,
 category_id Int NOT NULL
)
go
-- Create foreign keys (relationships) section ------------------------------------------------- 
ALTER TABLE [Actions] ADD CONSTRAINT [FK_Records_Actions] FOREIGN KEY (Attribute1) REFERENCES [Records] (record_id) ON UPDATE NO ACTION ON DELETE NO ACTION
go
ALTER TABLE [Actions] ADD CONSTRAINT [FK_User_Actions] FOREIGN KEY (Attribute2) REFERENCES [User] (user_id) ON UPDATE NO ACTION ON DELETE NO ACTION
go