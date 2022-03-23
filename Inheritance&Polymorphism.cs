*INHERITANCE*

//Parent -> Children
//naiinherit yung properties and functions ng parent

//ANIMAL//

public float speed;

virtual void Move(){
    
    //Move four legs
}


//DOG//
Move();

//CAT//
Move();


*POLYMORPHISM*

//Ability for child to change the function ng parent

//SNAKE//

override void Move(){
    //MOVE WHOLE BODY
}

//HUMAN//

override void Move(){
    //MOVE 2 legs
}






*OVERLOADING*

class Mouth{
    void Open(){
        //buksan bibeg
    }

    void Close(){
        //sara bibeg
    }
}

//HUMAN
void OpenMouth(Mouth mouth){
    mouth.Open();
}

void CloseMouth(Mouth mouth){
    mouth.Close();
}

void Move(Hand hand){
    hand.ShuffleFingers();
}

void Move(Mouth mouth){
    mouth.Open();
}

Move(bibigNiMina);


