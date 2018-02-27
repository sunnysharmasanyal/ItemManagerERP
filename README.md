# ItemManagerERP
Intership Project
                                   ItemManager(MiniERPSystem)
                                   
                              This project is aimed at developing an Inventory System for the Management of Goods Stored in the Inventory in the consumer wanted according to his requirement. The system is a full functional software for the Inventory related work. Containing all the requirement demanded by the user for carry out his day to day work .After analysing the requirements of the task to be performed, the next step is to analyse the problem and understand its context. The first activity in the phase is studying the existing system and other is to understand the requirements and domain of the new system. Both the activities are equally important, but the first activity serves as a basis of giving the functional specifications and then successful design of the proposed system. Understanding the properties and requirements of a new system is more difficult and requires creative thinking and understanding of existing running system is also difficult, improper understanding of present system can lead diversion from solution.     
                              
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
