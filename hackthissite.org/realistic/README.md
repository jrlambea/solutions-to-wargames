# hackthissite.org
## Realistic

**> Realistic 5: Damn Telemarketers!**

Telemarketers are invading people's privacy and peace and quiet. Get the password for the administrative section of the site to delete their database and return the privacy of their victims! 

    /robots.txt
    /secret/
    /secret/admin.bak.php // hash -> b22a419ce6932a5fbafe80f851045dd4
    /lib/hash // Un binario ELF que contiene MD4 en él.
---
    $ echo b22a419ce6932a5fbafe80f851045dd4 > hash.hash
    $ ./hashcat-cli64.bin -a 3 -m 900 hash.hash -1 ?l?d ?1?1?1?1?1

**Password**: e41f4
