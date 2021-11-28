export class Recipe {
  public id: number;
  public name: string;
  public description: string;
  public recipeCategory_Id: number;
  public createdAt: Date;
  public userId: number;
  public isDeleted: boolean;

  constructor(
    id: number,
    name: string,
    description,
    recipeCategory_Id: number,
    createdAt: Date,
    userId: number,
    isDeleted: boolean
  ) {
    this.id = id;
    this.name = name;
    this.description = description;
    this.recipeCategory_Id = recipeCategory_Id;
    this.createdAt = createdAt;
    this.userId = userId;
    this.isDeleted = isDeleted;
  }
}
