# hackthissite.org
## Basic
### Basic 1
*Basic test of your skills to see if you can do any of these missions. Requirements: HTML*

**> Level 1(the idiot test)**

This level is what we call "The Idiot Test", if you can't complete it, don't give up on learning all you can, but, don't go begging to someone else for the answer, thats one way to get you hated/made fun of. Enter the password and you can continue. 

Password en los comentarios HTML.

**Password:** 0dcb83e5

**> Level 2**

Network Security Sam set up a password protection script. He made it load the real password from an unencrypted text file and compare it to the password the user enters. However, he neglected to upload the password file...

Al no haber fichero de contraseñas no hay contraseña que comparar

**Password:**

**> Level 3**

This time Network Security Sam remembered to upload the password file, but there were deeper problems than that.

El password está en un fichero password.php

**Password:** 305692f4

**> Level 4**
This time Sam hardcoded the password into the script. However, the password is long and complex, and Sam is often forgetful. So he wrote a script that would email his password to him automatically in case he forgot. Here is the script:

El formulario donde reside el botón de recuperación de la contraseña se puede editar, substituyendo la dirección por cualquier otra.

**Password:** 4abe69e8

**> Level 5**

Sam has gotten wise to all the people who wrote their own forms to get the password. Rather than actually learn the password, he decided to make his email program a little more secure.

Igual que el anterior.
**Password:** 824381e4

**> Level 6**

Network Security Sam has encrypted his password. The encryption system is publically available and can be accessed with this form:

Probando la rutina de cifrado se puede ver que es un cifrado clásico tipo Caesar pero con incremento por cada posición de carácter, para revertirlo:

    var c = "73fgf;>i";
    var k;
    
    for (var i=0 ; i < c.length ; i++)
    {
        k += String.fromCharCode (c[i].charCodeAt(0) - i);
    }

**Password:** 72ddb68b

**> Level 7**

This time Network Security sam has saved the unencrypted level7 password in an obscurely named file saved in this very directory.
In other unrelated news, Sam has set up a script that returns the output from the UNIX cal command. Here is the script:

El script Perl que hicieron es vulnerable a Command Injection, por lo que si se introduce como año: `2015;ls` obtendremos una lista de los ficheros de ese mismo directorio:

    .
    ..
    
    cal.pl
    index.php
    k1kh31b1n55h.php
    level7.php

**Password:** 381f198a

**> Level 8**

Sam remains confident that an obscured password file is still the best idea, but he screwed up with the calendar program. Sam has saved the unencrypted password file in /var/www/hackthissite.org/html/missions/basic/8/

However, Sam's young daughter Stephanie has just learned to program in PHP. She's talented for her age, but she knows nothing about security. She recently learned about saving files, and she wrote a script to demonstrate her ability.

La web es vulnerable a SSI Command Injection. <!--#exec cmd="ls .." -->

**Password:**580cea9f

**> Level 9**

Network Security Sam is going down with the ship - he's determined to keep obscuring the password file, no matter how many times people manage to recover it. This time the file is saved in /var/www/hackthissite.org/html/missions/basic/9/.
In the last level, however, in my attempt to limit people to using server side includes to display the directory listing to level 8 only, I have mistakenly screwed up somewhere.. there is a way to get the obscured level 9 password. See if you can figure out how...
This level seems a lot trickier then it actually is, and it helps to have an understanding of how the script validates the user's input. The script finds the first occurance of '<--', and looks to see what follows directly after it. 

Se tendrá que aprovechar el formulario del nivel 8 para realizar otra inyección de SSI

**Password:** f5f7a30e
