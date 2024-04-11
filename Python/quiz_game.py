print("Welcome to my computer quiz!")

playing = input("Do you want to play? \n")

if playing.lower() != "yes":
    quit()

print("Okay! Let's play :).")
score = 0

answer = input("What does CPU stand for? \n ")
if answer.lower() == "central processing unit":
    print("Correct")
    score += 1
else:
    print("Incorrect!")

answer = input("What does GPU stand for? \n ")
if answer.lower() == "graphics processing unit":
    print("Correct")
    score += 1
else:
    print("Incorrect!")

answer = input("Whad does RAM stand for? \n ")
if answer.lower() == "random acces memory":
    print("Correct")
    score += 1
else:
    print("Incorrect!")

answer = input("Whad does PSU stand for? \n ")
if answer.lower() == "power supply":
    print("Correct")
    score += 1
else:
    print("Incorrect!")

print(f"You got {str(score)} questions correct!")
print(f"You got {str((score / 4) * 100)} %.")