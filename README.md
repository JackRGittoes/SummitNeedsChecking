Summat needs checking

A checksum is a small block of data which is derived from and added (typically) to the end of another block of data.  Its purpose is typically to verify the integrity of the data, not the authenticity. 
Your company is writing a help desk system.  To help ensure call references are not mistyped, you have been asked to write a function to validate a help desk call reference.  The rules around this are as follows:
•	The length of a reference is always 8 characters.
•	A reference will always start with a letter.
•	Only letters and numbers are allowed.
•	The last two characters of the reference will always be a checksum which will be 2 digits.
The algorithm to use for the checksum is as follows:
•	Add together the ASCII values of the first 6 characters of the reference.
•	The ASCII value for a character can be found by casting to an int
•	The resulting total should be divided by 100 with the remainder being used as the 2-digit checksum.
Your function is only required to return true if the supplied reference is valid or false if not.


