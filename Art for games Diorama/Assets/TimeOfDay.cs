

public static class TimeofDay
{
    
    //0 = midnight, .5 noon, .9999 = 23:59:59
    public static float globalTime;

    
    
    public static float Remap (this float value, float from1, float to1, float from2, float to2) {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }
   
}

