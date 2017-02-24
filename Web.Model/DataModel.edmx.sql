










































-- -----------------------------------------------------------
-- Entity Designer DDL Script for MySQL Server 4.1 and higher
-- -----------------------------------------------------------
-- Date Created: 02/21/2017 16:28:47

-- Generated from EDMX file: E:\textProject\WebApp\Web.Model\DataModel.edmx
-- Target version: 3.0.0.0

-- --------------------------------------------------


DROP DATABASE IF EXISTS `webapp`;
CREATE DATABASE `webapp`;
USE `webapp`;


-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- NOTE: if the constraint does not exist, an ignorable error will be reported.
-- --------------------------------------------------



-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------
SET foreign_key_checks = 0;

SET foreign_key_checks = 1;

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------


CREATE TABLE `UserInfoSet`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`UName` varchar (32), 
	`Pwd` varchar (16));

ALTER TABLE `UserInfoSet` ADD PRIMARY KEY (`Id`);





CREATE TABLE `RoleSet`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`RoleName` varchar (32));

ALTER TABLE `RoleSet` ADD PRIMARY KEY (`Id`);







-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
