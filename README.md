# DesignPatterns
# About the application
<p>The application represents a restaurant where clients are registered. After that, they can order, check their current order, tip, and remove meals from their order.</p>

## Implemented design patterns
* Creational patterns
    * Factory Method
* Structural patterns
    * Facade
* Behavioral patterns
    * Command
    

## Commands
* Register [ClientName]
* Order [MealName] [ClientName]
* RemoveMeal [ClientName] [MealName]
* Bill [ClientName]
* Tip [ClientName] [Amount]
* Menu
* Exit


## Input/Output
```bash
Input

Register Ivan
Register Simona
Order PepperoniPizza Ivan 
Order ProsciuttoPizza Ivan
Order GreekSalad Simona
Order VeganBurger Simona
Order ChickenBurger Simona
RemoveMeal Simona VeganBurger
Bill Simona
Tip Ivan 5
Bill Ivan
Exit

Output

Client Ivan registered.
Client Simona registered.
PepperoniPizza added to Ivan's order.
ProsciuttoPizza added to Ivan's order.
GreekSalad added to Simona's order.
VeganBurger added to Simona's order.
ChickenBurger added to Simona's order.
VeganBurger removed from Simona's order.
Bill for Simona
GreekSalad 7.40
ChickenBurger 6.90
                    Total 14.30$
-----------------------------------
Ivan tipped 5$.
Bill for Ivan
PepperoniPizza 8.99
ProsciuttoPizza 10.20
                    Total 24.19$
-----------------------------------
Today's total: 38.49$.
Shutting down app...

```


