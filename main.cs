#include <iostream>
using namespace std ;

// A C++ Program to Implement a Calendar for a given Year and Month

int main()
{
    int year, month, y, first_day, num_days;  // declare the variables

    do
    {
        cout << "enter the year between 1930 and 1999 , or -1 to end the input: ";    // prompt the user to enter the year , it must be between
        cin >> year;   // read values from keyboard                                  //  1930 and 1999

        if (year == -1)
            break;

    } while (year < 1930 || year > 1999);

    cout << endl;

    do
    {
        if (year == -1)
            break;

        cout << "enter the month according to the following numbering :" << endl;   // Prompt the user to enter the month between 1 and 12 according to those numbers
        cout << "March= 1, April = 2, May = 3, June = 4, July = 5, August = 6," << endl;
        cout << "September = 7, October = 8, November = 9, December = 10, January = 11, & February = 12: ";
        cin >> month;  // read values from keyboard
    } while (month < 1 || month > 12);

    cout << endl;

    while (year != -1)   // this loop will continue until the user enters the sentinel value -1
    {

        y = year % 100;  // y is a variable that represent the last 2 digits of the chosen year ( example : if year=1998 , y=98 )

        if (month == 11 || month == 12)
            first_day = (1 + (13 * month - 1) / 5 + y - 1 + 19 / 4 + (y - 1) / 4 - 2 * 19) % 7;  // this formula determines the first day of the entered year and month
        else                                                                 // we subtract 1 from y only if month is January(11) or February(12)
            first_day = (1 + (13 * month - 1) / 5 + y + 19 / 4 + y / 4 - 2 * 19) % 7;       // the first 1 in the formula represent the first day of the month
                                                                                            // 19 represent the first 2 digits of the entered year and y the second 2 digits
        switch (first_day)
        {
            case 0:                              // this switch structure represents the first day of the month  ,  if first_day=0 it’s Sunday
                cout << "first day is : Sunday ";   // Monday if first_day=1 , Tuesday if first_day= 2 ...etc.
                break;
            case 1:
                cout << "first day is : Monday ";
                break;
            case 2:
                cout << "first day is : Tuesday ";
                break;
            case 3:
                cout << "first day is : Wednesday ";
                break;
            case 4:
                cout << "first day is : Thursday ";
                break;
            case 5:
                cout << "first day is : Friday ";
                break;
            case 6:
                cout << "first day is : Saturday ";
                break;
        }
        cout << endl;

        switch (month)
        {                                                        // this switch structure link between the month and its number of days
            case 1:
                num_days = 31;                                                 // months with 31 days are : march,may,july,august,october,decembre,january
                cout << "the number of days in this month is 31 \n" << endl;
                cout << "March ";                      //months with 30 days are :april,june,septembre,novembre
                break;
            case 2:                                                       //February has 28 days or 29 days if it’s a leap year
                num_days = 30;
                cout << "the number of days in this month is 30 \n" << endl;
                cout << "April "; // print the current month name at the top of the calendar
                break;
            case 3:
                num_days = 31;
                cout << "the number of days in this month is 31 \n" << endl;
                cout << "May "; // print the current month name at the top of the calendar
                break;
            case 4:
                num_days = 30;
                cout << "the number of days in this month is 30 \n" << endl;
                cout << "June "; // print the current month name at the top of the calendar
                break;
            case 5:
                num_days = 31;
                cout << "the number of days in this month is 31 \n" << endl;
                cout << "July "; // print the current month name at the top of the calendar
                break;
            case 6:
                num_days = 31;
                cout << "the number of days in this month is 31 \n" << endl;
                cout << "August "; // print the current month name at the top of the calendar
                break;
            case 7:
                num_days = 30;
                cout << "the number of days in this month is 30 \n" << endl;
                cout << "September "; // print the current month name at the top of the calendar
                break;
            case 8:
                num_days = 31;
                cout << "the number of days in this month is 31 \n" << endl;
                cout << "October "; // print the current month name at the top of the calendar
                break;
            case 9:
                num_days = 30;
                cout << "the number of days in this month is 30 \n" << endl;
                cout << "November"; // print the current month name at the top of the calendar
                break;
            case 10:
                num_days = 31;
                cout << "the number of days in this month is 31 \n" << endl;
                cout << "December "; // print the current month name at the top of the calendar
                break;

            case 11:
                num_days = 31;
                cout << "the number of days in this month is 31 \n" << endl;
                cout << "January"; // print the current month name at the top of the calendar
                break;
            case 12:
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)                 // this general condition determines if the year entered is a leap year or no .
                {                                                           // for years between 1930 and 1999 it’s enough to just divide the year by 4
                    num_days = 29;                                          // if year is divisible by 4 , so year mode 4 is 0 , it’s a leap year
                    cout << "the number of days in this month is 29\n" << endl;// and number of days in February is 29 , if year mode 4 different then 0
                }                                                          // number of days in February is 28

                else
                {
                    num_days = 28;
                    cout << "the number of days in this month is 28\n" << endl;
                }
                cout << "February "; // print the month name at the top of the calendar
                break;
        }
        cout << endl;

        cout << "SUN" << '\t' << "MON" << '\t' << "TUE" << '\t' << "WED" << '\t' << "THU" << '\t' << "FRI" << '\t' << "SAT" << endl; // print the days of the calendar starting with Sunday

        for (int i = 1; i <= first_day; i++)   // this for structure will print the appropriate spaces before the first day
            cout << " \t";

        for (int j = 1; j <= num_days; j++)  // this for structure will print the days of the month
        {
            if ((j + first_day - 1) % 7 == 0 && (j != (7 - first_day)) && j != 1)  // this if structure is deduced from the switch structure below ,
                cout << endl;                                            // it will end the line after printing the day below each Saturday

            cout << j << "\t";
        }
        cout << endl << endl;

        /*    switch(first_day){
                case 0 :
                    if((j-1)%7==0  && j!=1)     (j-1) = (j+0-1) = (j+first_day-1)            j!=1 and when j=7 this value will be below SUN so it won’t end 
                        cout<<endl;                                                          the line so j!=7 has no effect on this case or others , 
                break;                                                                       j!=7  =  j!=(7-0)  =  j!=(7-firs_day) and N.B j!=1 has effect                
                case 1 :                                                                                                           only in this case not others                     
                    if((j+0)%7==0 && j!=6)      (j+0) = (j+1-1) = (j+first_day-1)            j!=6  =  j!=(7-1)  =  j!=(7-firs_day)
                        cout<<endl;
                break;
                case 2 :
                    if((j+1)%7==0 && j!=5)      (j+1) = (j+2-1) = (j+first_day-1)            j!=5  =  j!=(7-2)  =  j!=(7-firs_day)                                           
                        cout<<endl;
                break;
                case 3 :
                    if((j+2)%7==0 && j!=4)      (j+2) = (j+3-1) = (j+first_day-1)            j!=4  =  j!=(7-3)  =  j!=(7-firs_day)                                 
                        cout<<endl;
                break;
                case 4 :
                    if((j+3)%7==0 && j!=3)      (j+3) = (j+4-1) = (j+first_day-1)            j!=3  =  j!=(7-4)  =  j!=(7-firs_day)                                  
                        cout<<endl;
                break;
                case 5 :
                    if((j+4)%7==0 && j!=2)      (j+4) = (j+5-1) = (j+first_day-1)            j!=2  =  j!=(7-5)  =  j!=(7-firs_day)                                     
                        cout<<endl;
                break;
                case 6 :
                    if((j+5)%7==0 && j!=1)      (j+5) = (j+6-1) = (j+first_day-1)            j!=1  =  j!=(7-6)  =  j!=(7-firs_day)                                   
                        cout<<endl;
                break;
            }                                */
        do
        {
            cout << "enter the year between 1930 and 1999 , or -1 to end the input: ";    // prompt the user to enter the year , it must be between
            cin >> year;   // read values from keyboard                                  //  1930 and 1999

            if (year == -1)
                break;

        } while (year < 1930 || year > 1999);

        cout << endl;

        do
        {
            if (year == -1)
                break;

            cout << "enter the month according to the following numbering :" << endl; //Prompt the user to enter the month between 1 and 12 according to those numbers
            cout << "March= 1, April = 2, May = 3, June = 4, July = 5, August = 6," << endl;
            cout << "September = 7, October = 8, November = 9, December = 10, January = 11, & February = 12: ";
            cin >> month;  // read values from keyboard
        } while (month < 1 || month > 12);

        cout << endl;
    }



}


