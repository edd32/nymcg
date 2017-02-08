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

## Notes from the Book

“The important steps when adding a method to your own type are the following:
Choose a name for your method.
Decide which data should be passed to your method.
Decide which data you want to return to the caller.
Decide on the visibility of your method.”

Excerpt From: Wouter de Kort. “Exam Ref 70-483.” iBooks. https://itun.es/us/G3mNY.l