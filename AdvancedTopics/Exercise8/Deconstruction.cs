namespace AdvancedTopics.Exercise8
{
    public static class Deconstruction
    {
        //public static void Deconstruct<T>(this T[] items, out T firstItem, out T[] otherItems) where T : Computer// use the 'where' clause to only accept this type 
        //{
        //    firstItem = items.Length > 0 ? items[0] : default(T);
        //    otherItems = items.Length > 1 ? items[1..] : default(T[]);
        //}

        public static void Deconstruct<T>(this IEnumerable<T> items, out T firstItem, out T[] otherItems) where T : Computer
        {
            firstItem = items switch
            {
                Array array when array.Length > 0 => (T)array.GetValue(0), //kan ook: Array { Length: 1 } array => (T)array.GetValue(0),
                IList<T> list when list.Count > 0 => list[0],
                _ => default(T)
            };
            otherItems = items switch
            {
                Array array when array.Length > 1 => ((T[])array)[1..],
                IList<T> list when list.Count > 1 => list.TakeLast(list.Count - 1).ToArray(),
                _ => (default(T[]))
            };
        }
    }
}
