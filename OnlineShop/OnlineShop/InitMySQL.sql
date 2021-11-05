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
(1, 'Lenovo 14" ThinkPad E14 Gen 2 Multi-Touch Laptop', 26000000, 'Laptop', '2021/01/03'),
(2, 'Sony Google TV X80AJ', 10000000, 'TV', '2020-03-06'),
(3, 'Điện thoại iPhone 13 Pro Max', 30000000, 'Apple', '2021-11-02'),
(4, 'Samsung Galaxy S21 Ultra 5G', 22000000, 'Android', '2021-11-03'),
(5, 'LG G7 ThinQ 64GB', 25000000, 'Android', '2021-11-04'),
(6, 'Laptop Lenovo Ideapad Slim 5', 27000000, 'Laptop', '2021/02/13'),
(7, 'ASUS 15.6" Republic of Gamers Strix G15', 30000000, 'Laptop', '2021/01/03'),
(8, 'Laptop Microsoft Surface Go', 29000000, 'Laptop', '2021/01/03'),
(9, 'Laptop Asus Vivobook', 28000000, 'Laptop', '2021/01/03'),
(10, 'Laptop Asus UX425E i5-1135G7', 25000000, 'Laptop', '2021/01/03'),
(11, 'Laptop Lenovo Gaming 3', 24000000, 'Laptop', '2021/01/03'),
(12, 'Smart Tivi TCL 55 inch 4K', 8000000, 'TV', '2020-03-06'),
(13, 'Smart Tivi Casper 43 inch', 9000000, 'TV', '2020-03-06'),
(14, 'Android Tivi Casper 4K 50', 7000000, 'TV', '2020-03-06'),
(15, 'Smart Tivi LG 4K 49 inch', 11000000, 'TV', '2020-03-06'),
(16, 'Smart Tivi LG 4K 55 inch', 8000000, 'TV', '2020-03-06'),
(17, 'iPhone 11 64GB', 16000000, 'Apple', '2021-10-02'),
(18, 'MacBook Pro 14 inch 2021', 55000000, 'Apple', '2021-10-02'),
(19, 'MacBook Air 2021', 22000000, 'Apple', '2021-10-05'),
(20, 'iWatch Series 6', 400000, 'Apple', '2021-10-09'),
(21, 'Apple Watch Milan', 500000, 'Apple', '2021-10-02'),
(22, 'Google’s Pixel 5a 5G', 30000000, 'Android', '2021-10-01'),
(23, 'Samsung Galaxy S21 5G', 35000000, 'Android', '2021-09-01'),
(24, 'LG G6 Plus', 40000000, 'Android', '2021-09-01'),
(25, 'Motorola G6 Play', 50000000, 'Android', '2021-08-01'),
(26, 'Sony Xperia 1', 29000000, 'Android', '2021-07-01'),
(27, 'Samsung Galaxy Note 20 Ultra', 22000000, 'Android', '2021-06-01'),
(28, ' Xiaomi Mi 11', 10000000, 'Android', '2021-06-01'),
(29, 'Laptop MSI GL75 9SD-035VN', 25000000, 'Laptop', '2021/07/03'),
(30, 'ASUS 14" L410 Laptop', 26000000, 'Laptop', '2021-08-03');



SELECT * FROM Item;

DROP TABLE IF EXISTS `Onlineshop`.`Discount`;
CREATE TABLE IF NOT EXISTS `OnlineShop`.`Discount` (
  `Code` VARCHAR(5) NOT NULL,
  `Name` VARCHAR(50) NOT NULL,
  `Percentage` FLOAT NOT NULL,
  `ReleaseDate` DATE NOT NULL,
  `ExpirationDate` DATE NOT NULL,
  PRIMARY KEY (`Code`));

INSERT INTO Discount(Code, Name, Percentage, ReleaseDate, ExpirationDate) VALUES
('FHENH', 'Giảm 30%', 0.3, '2021-10-01', '2021-12-01'),
('GAHBY', 'Giảm 20%', 0.2, '2021-10-01', '2021-12-01'),
('TOVEK', 'Giảm 10%', 0.1, '2021-10-01', '2021-12-01'),
('HRBDS', 'Giảm 30%', 0.3, '2021-10-01', '2021-12-01'),
('UESBH', 'Giảm 50%', 0.5, '2021-10-01', '2021-11-01');

SELECT * FROM Discount;


DROP TABLE IF EXISTS `Onlineshop`.`Bill`;
CREATE TABLE IF NOT EXISTS `OnlineShop`.`Bill` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `Total` DECIMAL NOT NULL,
  `Address` VARCHAR(255) NOT NULL,
  `Date` DATE NOT NULL,
  `Discount` VARCHAR(5) NULL,
  `Status` ENUM('Ordering', 'Shipping', 'Success'),
  PRIMARY KEY (`ID`),
  CONSTRAINT `FK_Bill_Discount`
    FOREIGN KEY (`Discount`)
    REFERENCES `Onlineshop`.`Discount` (`Code`));
  
SELECT COUNT(ID)
FROM Bill
WHERE DAY(Date) = YEAR(curdate())
GROUP BY YEAR(Date);
  
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

SELECT COUNT(ID) FROM Bill WHERE DAY(`Date`) = DAY(CURDATE()) GROUP BY DAY(Date);
INSERT INTO Bill(ID, Total, Address, Date, Status) VALUES
(156, 1000000, '123 Nguyễn Trãi', '2021-01-01', 'Success');
UPDATE Bill SET Status = 'Shipping' WHERE ID = 1;
UPDATE Bill SET Status = 'Success' WHERE ID = 2;