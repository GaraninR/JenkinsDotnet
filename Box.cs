class Box {

    public Box() {

        this.h = 0;
        this.w = 0;
        this.l = 0;

    }

    public int w;
    public int h;
    public int l;

    public int getVolume() {
        return this.w * this.h * this.l;
    }
}