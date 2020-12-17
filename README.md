# customer-order-scheduling-LDR
This file is to provide instructions on using two new dispatching rules LDR-I.exe and LDR-II for solving customer order scheduling problem.

For ease of using, we decode LDR in C# with .net core 2.1 and generate this executable file LDR.exe.

Please follow these steps to run the LDR:

1. Make sure your platform is installed with .net core version 2.1 or above.
2. Check the format of data file. For example, given t1_0121,
	a) The first row "2 50" defines the number of machines, number of orders respectively;
	b) The rest rows specify the job processing time on each machine for each order.
3. Put the LDR.exe and the data files in the same folder. 
4. Double click LDR.exe, type in the data file name in the popup console window, press enter to run. See picture Example.

\textbf{Dataset}
