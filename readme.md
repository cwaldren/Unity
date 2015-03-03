You will need Unity Pro 4 and the Kinect for Windows v2 plug-in. The Unity plug-in can be found here: [Kinect for Windows v2 Unity Pro plug-in](http://go.microsoft.com/fwlink/?LinkID=513177 "Kinect for Windows v2 Unity Pro plug-in").

General steps to create a project:
-
1. Create a new Unity Project and add code to the Assest folder.
2. Import the .unityPackage for Kinect to the project.
3. Create a empty GameObject and add the BodySourceManager script to it. Name this BodySourceManager
4. Add a character model, be sure this is designed to match that of Kinect Y follows the direction of the bone.
5. From the Hierarchy, select the model and from the Kinect menu select Create KinectMapper
6. From the Inspector, map specific joints you want to see affect on the model. Remember, Kinect joint rotations are for the parent.

Joint Visualizer
-
1. To see a representation of the Kinect model in the world, create a new GameObject.
2. Add the Visualizer script to it.
3. You can add the joint and bone model from the Models folder to the respective fields in the Inspector


 