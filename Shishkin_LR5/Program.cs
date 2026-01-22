
using Shishkin_LR5;

HoursToMinute converter = new HoursToMinute();
int h, m;
converter.Read(out h, out m);
int total = converter.Minutes(h, m);
converter.Display(h, m, total);
