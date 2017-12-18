# SQLGenerator

Generates SQL Statements for lazy people.
Built for the DBS1 exam.

Example for question number 1

Diagram:

[![N|Solid](http://i.imgur.com/BCjcszp.png)](en.via.dk)

Analysis must hold a reference to a survey and a survey can have more than one analysis.
I chose the parent survey name as foreign key, could be any attribute.

On the program:
Enter table name (Survey). 
Right-click on the attribute you want to be remembered for the other table, a pink border will show up, 
that means that the attribute will be generated for the next generation with values from this generation.
I chose the name (Random full name) as the attribute to be rememberd.


[![N|Solid](http://i.imgur.com/5C8kWuq.png)](en.via.dk)

Click on all desired values (buttons), be creative.

[![N|Solid](http://i.imgur.com/dI2uQgk.png)](en.via.dk)

You can see the positions of the VALUES and a preview of the SQL Statement.

Go on the number of generations field, type a number of entries to generate, let's say 5. You get 5 statements

* INSERT INTO Survey VALUES ( 0210, 8494, '05/04/2018', 'Brian Henriksen');
* INSERT INTO Survey VALUES ( 4081, 6755, '13/06/2018', 'Rebecca Dethlefsen');
* INSERT INTO Survey VALUES ( 5680, 1037, '22/08/2018', 'Cody Beske');
* INSERT INTO Survey VALUES ( 9432, 6861, '28/03/2018', 'Jordan Helgesen');
* INSERT INTO Survey VALUES ( 3806, 7533, '26/04/2018', 'Brianna Bagge');

The names (Last attributes) will be remembered for the next generation.
Generate next table:

CLICK RESET ONCE!

Give a table name, here Analysis.
Following the diagram we need number, name, type, price and parent survey name. 
Remember SQL VALUES are positional arguments, so generate in this order. 
If you screw up you need to close the app and start from scratch :)
The name of the Analysis is not a human name, so click on any other button like Department or City for
some other random data

The type is amateur/pro

Now for 'parent survey name' click on the button with pink border (remembered from last generation)

Generate 20 entries

* INSERT INTO Analysis VALUES ( 7035, 'Orco', 'Proffessional', 6474, 'Jordan Helgesen');
* INSERT INTO Analysis VALUES ( 4801, 'Herolutions', 'Amateur', 5631, 'Brian Henriksen');
* INSERT INTO Analysis VALUES ( 2578, 'Orco', 'Proffessional', 7393, 'Jordan Helgesen');
* INSERT INTO Analysis VALUES ( 4835, 'Phoenixstones', 'Proffessional', 8768, 'Brian Henriksen');
* INSERT INTO Analysis VALUES ( 6227, 'Padlockurity', 'Proffessional', 1168, 'Brian Henriksen');
* INSERT INTO Analysis VALUES ( 8738, 'Squidustries', 'Proffessional', 1577, 'Cody Beske');
* INSERT INTO Analysis VALUES ( 9833, 'Elecoms', 'Proffessional', 7701, 'Rebecca Dethlefsen');
* INSERT INTO Analysis VALUES ( 1477, 'Pinnacle Entertainment', 'Proffessional', 9956, 'Brian Henriksen');
* INSERT INTO Analysis VALUES ( 4561, 'Angelico', 'Proffessional', 1743, 'Brian Henriksen');
* INSERT INTO Analysis VALUES ( 6206, 'Parableutions', 'Proffessional', 4392, 'Brian Henriksen');
* INSERT INTO Analysis VALUES ( 3784, 'Wizardwell', 'Proffessional', 3546, 'Rebecca Dethlefsen');
* INSERT INTO Analysis VALUES ( 0473, 'Fire Foods', 'Proffessional', 2369, 'Brian Henriksen');
* INSERT INTO Analysis VALUES ( 5399, 'Mount Solutions', 'Amateur', 4756, 'Brian Henriksen');
* INSERT INTO Analysis VALUES ( 7305, 'Betarts', 'Amateur', 2558, 'Brian Henriksen');
* INSERT INTO Analysis VALUES ( 1954, 'Crowares', 'Amateur', 0066, 'Rebecca Dethlefsen');
* INSERT INTO Analysis VALUES ( 8056, 'Omegacoustics', 'Amateur', 5283, 'Brianna Bagge');
* INSERT INTO Analysis VALUES ( 8082, 'Orco', 'Amateur', 6602, 'Jordan Helgesen');
* INSERT INTO Analysis VALUES ( 6475, 'Robinmaster', 'Proffessional', 7434, 'Brianna Bagge');
* INSERT INTO Analysis VALUES ( 0285, 'Quadphone', 'Amateur', 2685, 'Brian Henriksen');
* INSERT INTO Analysis VALUES ( 0395, 'Titaniumotors', 'Proffessional', 5450, 'Rebecca Dethlefsen');

all of them have the name of one of the parents (foreign key)

If you want to generate new data for other tables, restart the app.

Currently it can only remember one attribute, if you want it better, modify it yourself.

