*ABSTRACTION*

//Create a single function for one purpose
//Avoids duplication

class LightBulb{

    Color color;
    int num;

    color = red;

    void ChangeColor(Color _color){
        color = _color;
    }
}

LightBulb lightBulb();

lightBulb.ChangeColor(red);
