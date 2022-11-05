class Sheep: IAnimal
{
    public void accept(IWorker visitor)
    {
        throw new NotImplementedException();
    }

    public bool isShearable(){
        return false;
    }
}