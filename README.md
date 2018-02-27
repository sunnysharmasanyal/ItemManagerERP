# ItemManagerERP
Intership Project
                                   ItemManager(MiniERPSystem)
                                   
                              Mini ERP an internship project made of three tier artitecture.
                              
Technologies used : Windows Application C#.net, SQL, MetroUI-Framework,RDLC Reports etc...
The Project is made with the three-tier architecture. the project incorporated different layers to have full assistance in future development if project needs to be extended. the project has three layer listed below 
1.	BLL: Business logic layer containing all the logic need to operate the software 
2.	DAL: Data logic layer containing all the connection code related to adapters and commands and other SQL connection related logics 
3.	DTO: Data objects containing all the properties that is used to carry out the data in out in the software for carrying functionality.
4.	Presentation layer: it’s the third layer that contains the code for the user interface and logic code for functionality related to front end 

2.7. PROCESS MODELS USED WITH JUSTIFICATION
ACCESS CONTROL FOR DATA WHICH REQUIRE USER AUTHENTICATION

The following commands specify access control identifiers and they are typically used to authorize and authenticate the user (command codes are shown in parentheses) 
USER NAME (USER)
The user identification is that which is required by the server for access to its file system. This command will normally be the first command transmitted by the user after the control connections are made (some servers may require this). 
PASSWORD (PASS) 
This command must be immediately preceded by the user name command, and, for some sites, completes the user's identification for access control. Since password information is quite sensitive, it is desirable in general to "mask" it or suppress type out
