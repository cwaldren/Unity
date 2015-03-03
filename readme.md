Create a new Unity Project and add code to the Assest folder.

General steps to create a project:
- 
1. Create a empty GameObject and add the BodySourceManager script to it. Name this BodySourceManager
2. Add a character model, be sure this is designed to match that of Kinect Y follows the direction of the bone.
3. From the Hierarchy, select the model and from the Kinect menu select Create KinectMapper
4. From the Inspector, map specific joints you want to see affect on the model. Remember, Kinect joint rotations are for the parent.

Joint Visualizer
-
1. To see a representation of the Kinect model in the world, create a new GameObject.
2. Add the Visualizer script to it.
3. You can add the joint and bone model from the Models folder to the respective fields in the Inspector


 