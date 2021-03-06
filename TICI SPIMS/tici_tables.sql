CREATE DATABASE spimsdb;
use spimsdb;
CREATE TABLE USERS(
UID INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
USERNAME VARCHAR(30) NOT NULL,
PASSWD VARCHAR(200) NOT NULL,
FULL_NAME VARCHAR(50),
JOB VARCHAR(20),
RX VARCHAR(10) NOT NULL,
USER_LOCK VARCHAR(20)
);

CREATE TABLE AUDIT_TRAIL(
ACTION_ID INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
UID INT NOT NULL,
ACTION_TIME VARCHAR(25),
ACTION VARCHAR(100) NOT NULL
);

CREATE TABLE CASH_TRANS(
TRANS_ID INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
TRANS_OR_ID VARCHAR(15) NOT NULL,
TRANS_VISIT_ID INT NOT NULL,
TRANS_TIME VARCHAR(25),
TRANS_NOTE VARCHAR(20)
);

CREATE TABLE SALES_REPORT(
SALE_DAY_ID INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
SALE_DATE VARCHAR(25),
SALE_CASH DECIMAL(19,2) NOT NULL DEFAULT 0,
SALE_NOTES VARCHAR(255)
);

CREATE TABLE PATIENT(
PT_ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
PT_CASE_NO VARCHAR(20),
PT_LN VARCHAR(20),
PT_FN VARCHAR(20),
PT_MN VARCHAR(20),
PT_DOB VARCHAR(20), 
PT_CSTAT VARCHAR(20),
PT_SEX VARCHAR(10),
PT_CONTACT_NO VARCHAR(15),
PT_TYPE VARCHAR(10),

PT_BRGY VARCHAR(20),
PT_CITY VARCHAR(20),
PT_PROV VARCHAR(20),
PT_OCC VARCHAR(20),
PT_ALLERGY VARCHAR(30),
PT_IMPLANT VARCHAR(20),
PT_CLAUSTRO VARCHAR(10),

PT_ENAME VARCHAR(30),
PT_ECONTACT VARCHAR(15),
PT_HMO VARCHAR(30),
PT_HMO_ID VARCHAR(15),
PT_LAST_UPDATE VARCHAR(25),

ROW_LOCK VARCHAR(2)
);

CREATE TABLE PT_VISIT(
VS_ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
PT_ID INT NOT NULL, 
VS_DATE_VISIT VARCHAR(25),
VS_DOC VARCHAR(30),
VS_HISTORY VARCHAR(65536),
VS_NOTES VARCHAR(65536)
);

CREATE TABLE SERVICES(
SV_ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
SV_NAME VARCHAR(20) NOT NULL,
SV_TYPE VARCHAR(20) NOT NULL,
PRICE DECIMAL(19,2) NOT NULL 
);

CREATE TABLE PT_VISIT_SERVICE(
ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,

SV_NAME VARCHAR(20) NOT NULL,

PV_ID INT NOT NULL,

SV_PRICE DECIMAL(19,2) NOT NULL, 

PT_STATUS VARCHAR(10) DEFAULT 'UNPAID',

SV_DATE VARCHAR(25),

SV_ATTENDANT INT 
);




INSERT INTO `USERS` (`USERNAME`, `PASSWD`, `FULL_NAME`, `RX`) VALUES
( 'user', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', 'Level 1 User', 'g'),
( 'admin', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', 'Admin User', 'gca');
