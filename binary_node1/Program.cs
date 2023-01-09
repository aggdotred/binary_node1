using binary_node1;

BinaryNode<string> rootNode = new BinaryNode<string>("Root");
BinaryNode<string> aNode = new BinaryNode<string>("A");
BinaryNode<string> bNode = new BinaryNode<string>("B");
BinaryNode<string> cNode = new BinaryNode<string>("C");
BinaryNode<string> dNode = new BinaryNode<string>("D");
BinaryNode<string> eNode = new BinaryNode<string>("E");
BinaryNode<string> fNode = new BinaryNode<string>("F");

rootNode.AddLeft(aNode);
rootNode.AddRight(bNode);

aNode.AddLeft(cNode);
aNode.AddRight(dNode);

bNode.AddRight(eNode);

eNode.AddLeft(fNode);

Console.WriteLine(rootNode.ToString());
Console.WriteLine(aNode.ToString());
Console.WriteLine(bNode.ToString());
Console.WriteLine(cNode.ToString());
Console.WriteLine(dNode.ToString());
Console.WriteLine(eNode.ToString());
Console.WriteLine(fNode.ToString());
