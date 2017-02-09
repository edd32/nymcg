# Topic Questions for Types

1. When are enums useful?
2. What are types?
3. What is boxing/unboxing?
4. What's the difference between static and dynamic?
5. What's an ExpandoObject?


# Videos

1. [Generics](https://www.lynda.com/C-tutorials/Understanding-benefits-generics/388134/435153-4.html?srchtrk=index%3a1%0alinktypeid%3a2%0aq%3aC%23+generics%0apage%3a1%0as%3arelevance%0asa%3atrue%0aproducttypeid%3a2)
2. [Code Challenge](https://www.lynda.com/C-tutorials/Challenge-Getting-information-from-list/388134/435157-4.html?srchtrk=index%3a1%0alinktypeid%3a2%0aq%3aC%23+generics%0apage%3a1%0as%3arelevance%0asa%3atrue%0aproducttypeid%3a2)

## Examples

```
enum DaysofWeek : byte { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };
```
## Implicit vs Explicit Conversions

```
int i = 234;
double x = i;


double y = 123.3;
int w;
w = (int)y;

```


### Struct 

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

### ICollection

```
class Note {}

class Notes {
    public ICollection<Note> Notes {get; private set;}
}

```
### Generic

```

public void Generic<T>()
{
    T defaultValue = default(T);
}

```

## Notes
1. [Law of Demeter](https://en.wikipedia.org/wiki/Law_of_Demeter)

## Notes from the Book

“The important steps when adding a method to your own type are the following:
Choose a name for your method.
Decide which data should be passed to your method.
Decide which data you want to return to the caller.
Decide on the visibility of your method.”

Excerpt From: Wouter de Kort. “Exam Ref 70-483.” iBooks. https://itun.es/us/G3mNY.l


“The constructor also runs some code to make sure that the object is in a usable state. Some good practices when designing your constructors are these:
Explicitly declare the public default construct in classes if such a constructor is required.
Ensure that your constructor takes as few parameters as possible.
Map constructor parameters to properties in your class.
Throw exceptions from instance constructors if appropriate.
Do not call virtual members from an object inside its constructor.”

Excerpt From: Wouter de Kort. “Exam Ref 70-483.” iBooks. https://itun.es/us/G3mNY.l