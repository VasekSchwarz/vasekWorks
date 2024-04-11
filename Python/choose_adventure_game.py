name = input("Type your name: ")
print("Welcome", name, "to this adventure!")

answer = input("You are on a dirt road, it has come to an end and you can go left or right. Which way wolud you like to go? ").lower()

if answer == "left":
    answer = input("You come to a river, you can walk around it or swimm accross? Type walk to walk arround and swim to swim accross: ").lower()

    if answer == "swim":
        print("You swam accross and were eaten by an alligator.")
    elif answer == "walk":
        print("You walked many kilometers, ran out of water and lost the game")
    else:
        print("Not valid option. You lose.") 

elif answer == "right":
    answer = input("You come to a bridge, it looks woobly, do you want to cross it or head back? (cross/back) ")

    if answer == "back":
        print("You go back and loose.")
    elif answer == "cross":
       answer = input("You cross the bridge and meet a stranger. Do you talked to them (yes/no)?").lower()

       if answer == "yes":
           print("You talked to the stranger and they give you gold. You Win!")
       elif answer == "no":
            print("You ignore the stranger and they are offended and you lose.")
       else:
           print("Not valid option. You lose.")
           
    else:
       print("Not valid option. You lose.")  

else:
    print("Not valid option. You lose.")