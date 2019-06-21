Homework for TCP/UDP Socket Programming
================================================

Hmw No : #3
Hmw Name : CinsDownload Manager
Hmw Short Name : CiDoMa
Hmw Start Date : 13 May 2019, 13:00
Hmw Due Date : 27 May 2019, 23:30
Urgent : [On time, no later submission are accepted]
Lecturer : Assoc.Prof.Dr.Muhammet Cinsdikici
Class : NetPrg Class (1,2)

Homework Description:
---------------------
CinsDownload Manager(CiDoMa) is used for downloading Movie/Music Files
from 3 Download Servers to the requesting client software. This download 
done by CinsDownload Manager via parallel sessions.
----------------------

Homework Materials:
------------------
a. TCP/UDP Socket programming is used for the homework platform.
b. TcpClient and UdpClient helper classes may be used (Binary Transfers ?)
c. Your design belongs to you. Whatever you want, you can use it. But, obey the IRs.

Homework Rules:
----------------
IR1: We have supposed to know the file names of the Movie/Music Files at Client Side.
(Do not struglle with automatic checking Server directory for file names)
IR2: We are going to use Server(0), Server(1), Server(2). All of them holds the same files
in the same directy path. (i.e. c:\CiDoMa\Movie\ and c:\CiDoMa\Music)
IR3: When the client gets the name of the requested file on CinsDownload Manager's GUI,
CiDoMa software downloads file from Triple Servers at the same time in this manner:
- Files are binary, not Text...
- 1000 byte is considered as block size/chunk size
- Take the size of file (request from one of the Triple Servers)
- According to the size of the file we are going to request the id# of 
chunk from the related Server(x). For example, bytes (17.000-17.999) 
of the requested file means that, 17.block/chunk, so (17 Modulus 3) = 2.
In other words, CiDoMa software gets the 17.block of file from Server(2).

IR4: All of the chunks are gathered in client PC as a single movie/music file. 
IR5: We should see the download progress operation from Servers on GUI.
IR6: After construction of the file, we are going to open the file on GOM Player (real test).

The Grading is done as ;
-----------------------
- 25 points for report of the homework (in paper format)
- 75 points for Code itself
