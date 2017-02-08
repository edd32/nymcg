# Topic Questions for Types

1. When are enums useful?


## Examples

```
enum Days : byte { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };
```

```

public struct Point 
{
    public int x,y;

    public Point(int one, int two) {
        x = one;
        y = two;
    }
}

```

```
class Note {}

class Notes {
    public ICollection<Note> Notes {get; private set;}
}

```

```

public void Generic<T>()
{
    T defaultValue = default(T);
}

```

## Notes from the Book

“The important steps when adding a method to your own type are the following:
Choose a name for your method.
Decide which data should be passed to your method.
Decide which data you want to return to the caller.
Decide on the visibility of your method.”

Excerpt From: Wouter de Kort. “Exam Ref 70-483.” iBooks. https://itun.es/us/G3mNY.l

[Law of Demeter](https://en.wikipedia.org/wiki/Law_of_Demeter)

“The constructor also runs some code to make sure that the object is in a usable state. Some good practices when designing your constructors are these:
Explicitly declare the public default construct in classes if such a constructor is required.
Ensure that your constructor takes as few parameters as possible.
Map constructor parameters to properties in your class.
Throw exceptions from instance constructors if appropriate.
Do not call virtual members from an object inside its constructor.”

Excerpt From: Wouter de Kort. “Exam Ref 70-483.” iBooks. https://itun.es/us/G3mNY.l