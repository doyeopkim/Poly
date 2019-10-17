package CHAPTER_5;

public class p264_1 {
		private int year;
		private String month;
		private int day;
		
		public p264_1() {
			this(1900, "1¿ù", 1);
		}
		
		public p264_1(int year) {
			this(year, "1¿ù", 1);
		}
		
		public p264_1(int year, String month, int day) {
			this.month = month;
			this.day = day;
			this.year = year;
		}
		
		@Override
		public String toString() {
			return "Date [year=" + year + ", mont=" + month + ", day=" + day + "]";
		}
}