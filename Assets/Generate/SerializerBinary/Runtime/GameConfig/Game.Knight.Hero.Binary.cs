using System.IO;
using Core;
using Core.Serializer;


/// <summary>
/// 文件自动生成无需又该！如果出现编译错误，删除文件后会自动生成
/// </summary>
namespace Game.Knight
{
public partial class Hero
{
	public override void Serialize(BinaryWriter rWriter)
	{
		base.Serialize(rWriter);
		rWriter.Serialize(this.ID);
		rWriter.Serialize(this.Name);
		rWriter.Serialize(this.AvatarID);
		rWriter.Serialize(this.SkillID);
		rWriter.Serialize(this.Scale);
		rWriter.Serialize(this.Height);
		rWriter.Serialize(this.Radius);
	}
	public override void Deserialize(BinaryReader rReader)
	{
		base.Deserialize(rReader);
		this.ID = rReader.Deserialize(this.ID);
		this.Name = rReader.Deserialize(this.Name);
		this.AvatarID = rReader.Deserialize(this.AvatarID);
		this.SkillID = rReader.Deserialize(this.SkillID);
		this.Scale = rReader.Deserialize(this.Scale);
		this.Height = rReader.Deserialize(this.Height);
		this.Radius = rReader.Deserialize(this.Radius);
	}
}
}
