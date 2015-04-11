All programming done in Visual Studio Ultimate 2013
Database: Mysql
DBSM: HeidiSql
IMPORTANT: To develop you'll need to install the MySql connector provided in this repo

#The program:

The program is a school project where the intention is to monitor the temperature within
a cabin. All recordings are done by using an Arduino to transfer analog data to a computer.
The program will then trigger an alarm if the real_temp value is outside of the defined setpoints.
An alarm will be sent to a set of subscribers via email.
Every alarm, recording, subscriber info and settings are stored in a MYSQL database.


Gridview for alarms. Collums edited in GUI for gridview. Autosize and fill.


Changes:

Enabled AUTO_INCREMENT in MySQL Via HEidiSQL
Enabled auto-timestamp in Mysql via Heidisql

How To:
Add datasource to graph:
Add dataset
Add graph
Graph properties->Data->Datasource

