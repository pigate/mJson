using System;
using System.Collections.Generic;
using System.Text;

namespace mJSON
{
    class JsonSimpleObject
    {
        Dictionary<string, string> d = new Dictionary<string, string>();
        Dictionary<string, int> d_int = new Dictionary<string, int>();
        Dictionary<string, decimal> d_dec = new Dictionary<string, decimal>();
        Dictionary<string, long> d_long = new Dictionary<string, long>();
        Dictionary<string, DateTime> d_datetime = new Dictionary<string, DateTime>();
        Dictionary<string, bool> d_bool = new Dictionary<string, bool>();
        List<string> d_keys = new List<string>();
        List<string> d_int_keys  = new List<string>();
        List<string> d_dec_keys  = new List<string>();
        List<string> d_long_keys = new List<string>();
        List<string> d_datetime_keys = new List<string>();
        List<string> d_bool_keys = new List<string>();
        public void AddString(string key, string value)
        {
            d[key] = value;
            if (!d_keys.Contains(key))
            d_keys.Add(key);
        }

        public void AddChar(string key, char c)
        {
            d[key] = Char.ToString(c);
            if (!d_keys.Contains(key))
                d_keys.Add(key);
        }

        public void AddInt(string key, int value)
        {
            d_int[key] = value;
            if (!d_int_keys.Contains(key))
                d_int_keys.Add(key);
        }

        public void AddDec(string key, decimal value)
        {
            d_dec[key] = value;
            if (!d_dec_keys.Contains(key))
                d_dec_keys.Add(key);
        }

        public void AddLong(string key, long value)
        {
            d_long[key] = value;
            if (!d_long_keys.Contains(key))
                d_long_keys.Add(key);
        }

        public void AddDateTime(string key, DateTime value)
        {
            d_datetime[key] = value;
            if (!d_datetime_keys.Contains(key))
                d_datetime_keys.Add(key);
        }

        public void AddBool(string key, bool value)
        {
            d_bool[key] = value;
            if (!d_bool_keys.Contains(key))
                d_bool_keys.Add(key);
        }

        public void Remove(string key)
        {
            if (d.ContainsKey(key))
            {
                d.Remove(key);
                d_keys.Remove(key);
            }
            else if (d_int.ContainsKey(key))
            {
                d_int.Remove(key);
                d_int_keys.Remove(key);
            }
            else if (d_dec.ContainsKey(key))
            {
                d_dec.Remove(key);
                d_dec_keys.Remove(key);
            }
            else if (d_long.ContainsKey(key))
            {
                d_long.Remove(key);
                d_long_keys.Remove(key);
            }
            else if (d_datetime.ContainsKey(key))
            {
                d_datetime.Remove(key);
                d_datetime_keys.Remove(key);
            }
            else if (d_bool.ContainsKey(key))
            {
                d_bool.Remove(key);
                d_bool_keys.Remove(key);
            }
        }
        
        public string GetString(string key)
        {
            return d[key];
        }

        public char GetChar(string key)
        {
            return Convert.ToChar(d[key]);
        }

        public int GetInt(string key)
        {
            return d_int[key];
        }

        public decimal GetDec(string key)
        {
            return d_dec[key];
        }

        public long GetLong(string key)
        {
            return d_long[key];
        }

        public DateTime GetDateTime(string key)
        {
            return d_datetime[key];
        }

        public bool GetBool(string key)
        {
            return d_bool[key];
        }

        public string ToString()
        {
            int propCount = 0;
            StringBuilder sb = new StringBuilder("{");
            int Ct = 0;
            Ct = d_keys.Count;
            for (int i = 0; i < Ct; i++)
            {
                sb.Append(@"""" + d_keys[i] + @""":""" + d[d_keys[i]] + @""",");
                propCount++;
            }
            Ct = d_int_keys.Count;
            for (int i = 0; i < Ct; i++)
            {
                sb.Append(@"""" + d_int_keys[i] + @""":" + d_int[d_int_keys[i]].ToString() + @",");
                propCount++;
            }
            Ct = d_dec_keys.Count;
            for (int i = 0; i < Ct; i++)
            {
                sb.Append(@"""" + d_dec_keys[i] + @""":" + d_dec[d_dec_keys[i]].ToString() + @",");
                propCount++;
            }
            Ct = d_long_keys.Count;
            for (int i = 0; i < Ct; i++)
            {
                sb.Append(@"""" + d_keys[i] + @""":" + d_long[d_long_keys[i]].ToString() + @",");
                propCount++;
            }
            Ct = d_datetime_keys.Count;
            for (int i = 0; i < Ct; i++)
            {
                sb.Append(@"""" + d_keys[i] + @""":""" + ConvertDateTimeToString(d_datetime[d_datetime_keys[i]]) + @""",");
                propCount++;
            }
            Ct = d_bool_keys.Count;
            for (int i = 0; i < Ct; i++)
            {
                sb.Append(@"""" + d_keys[i] + @""":" + d_bool[d_bool_keys[i]].ToString() + @",");
                propCount++;
            }
            if (propCount > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            sb.Append("}");
            
            return sb.ToString();
        }

        private string ConvertDateTimeToString(DateTime dt)
        {
            return dt.ToString("s");
        }
    }
}
