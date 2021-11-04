DROP SCHEMA IF EXISTS `OnlineShop`;

CREATE SCHEMA IF NOT EXISTS `OnlineShop` DEFAULT CHARACTER SET utf8 ;
USE `OnlineShop`;


DROP TABLE IF EXISTS `Onlineshop`.`Item`;
CREATE TABLE IF NOT EXISTS `OnlineShop`.`Item` (
  `ID` INT NOT NULL,
  `Name` VARCHAR(50) NOT NULL,
  `Price` DECIMAL NOT NULL,
  `Type` Enum('Laptop', 'Apple', 'Android', 'TV'),
  `Date` DATE NOT NULL,
  PRIMARY KEY (`ID`));
  
DELETE FROM Item;

INSERT INTO Item(ID,Name,Price,Type,Date) VALUES
(1, 'a', 10000, 'Laptop', '2021/01/03'),
(2, 'b', 10000, 'TV', '2020-03-06'),
(3, 'c', 20000, 'Apple', '2021-11-02'),
(4, 'd', 40000, 'Android', '2021-11-01'),
(5, 'ad', 40000, 'Android', '2021-11-01');

SELECT * FROM Item;

DROP TABLE IF EXISTS `Onlineshop`.`Bill`;
CREATE TABLE IF NOT EXISTS `OnlineShop`.`Bill` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `Total` DECIMAL NOT NULL,
  `Address` VARCHAR(255) NOT NULL,
  `Date` DATE NOT NULL,
  `Status` ENUM('Receiving', 'Shipping', 'Success'),
  PRIMARY KEY (`ID`));
  
DROP TABLE IF EXISTS `Onlineshop`.`OrderDetail`;
CREATE TABLE IF NOT EXISTS `OnlineShop`.`OrderDetail` (
  `BillID` INT NOT NULL,
  `ItemID` INT NOT NULL,
  `Amount` INT NOT NULL,
  PRIMARY KEY (`BillID`, `ItemID`),
  CONSTRAINT `FK_OrderDetail_Item`
    FOREIGN KEY (`ItemID`)
    REFERENCES `Onlineshop`.`Item` (`ID`),
  CONSTRAINT `FK_OrderDetail_Bill`
    FOREIGN KEY (`BillID`)
    REFERENCES `OnlineShop`.`Bill` (`ID`));
    
    
DELETE FROM Bill;

SELECT * FROM Bill;
SELECT * FROM OrderDetail;
    