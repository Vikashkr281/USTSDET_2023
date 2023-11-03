// See https://aka.ms/new-console-template for more information
using Assignment_2_Ds_03_nov;


        FamilyMember grandparent = new FamilyMember("Grandparent", 70);
        FamilyMember parent1 = new FamilyMember("Parent 1", 40);
        FamilyMember parent2 = new FamilyMember("Parent 2", 38);
        FamilyMember child1 = new FamilyMember("Child 1", 12);
        FamilyMember child2 = new FamilyMember("Child 2", 8);

        grandparent.AddChild(parent1);
        grandparent.AddChild(parent2);
        parent1.AddChild(child1);
        parent2.AddChild(child2);

        FamilyTree familyTree = new FamilyTree(grandparent);
        familyTree.DisplayFamilyTree();