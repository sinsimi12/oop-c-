*ENCAPSULATION*

   //Setting variables private to let other developers know that they should not mess or access the variable

   private float _seconds = 7200;

    //PROPERTY
   public float Hours 
   {
       get { return _seconds / 3600; }
       set {
          if (value < 0 || value > 24)
             throw new ArgumentOutOfRangeException(
                   $"{nameof(value)} must be between 0 and 24.");

          _seconds = value * 3600;
       }
   }

   print(_seconds);
   //7200

   print(Hours);
   //2

    Hours.value = -2.5f
    //ERROR
