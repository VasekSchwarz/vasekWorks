import random

top_of_range = input("Type a number: ")

if top_of_range.isdigit(): # v podmice se ptáme, jestli se jedná o číslici
    top_of_range = int(top_of_range) #převod stringu na int
    if top_of_range <= 0:
        print("Please type a number larger than 0 next time")
        quit()
else:
    print("PLease type a number next time.")
    quit()

random_number = random.randint(0,top_of_range) # vygeneruj náhodné číslo (start, stop)

guesses = 0  

while True:
    guesses += 1 # s každým pokusem zvyšujeme proměnou o 1(na konci nám to ukáže na kolikátý pokus jsme číslo uhodli)
    user_guess = input("Make a guess: ")
    if user_guess.isdigit():
        user_guess = int(user_guess)
    else:
        print("Please type a number next time.")
        continue
   
    if user_guess == random_number:
        print("You got it!")
        break # po uhodnutém čísle přeruší hru(ukončí cyklus)
    elif user_guess > random_number: # tato        podmíka radí hráči, jestli se nachází na číslem, nebo pod číslem
        print("You wer above the number!")
    else:
        print("You were below the number!")

print(f"You got it in {guesses} guesses.")
