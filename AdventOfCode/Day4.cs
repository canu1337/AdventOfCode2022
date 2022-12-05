﻿internal static class Day4
{
    private static void Day4Part1()
    {
        var input = "22-65,22-66\r\n91-94,63-91\r\n6-88,5-31\r\n85-86,64-86\r\n40-65,40-65\r\n25-82,24-94\r\n68-69,68-92\r\n60-91,89-92\r\n3-72,3-73\r\n44-85,84-85\r\n15-72,14-72\r\n84-92,84-92\r\n10-84,3-10\r\n32-62,31-61\r\n14-98,98-99\r\n24-78,24-61\r\n2-5,5-89\r\n58-95,58-59\r\n39-93,92-93\r\n11-82,81-82\r\n12-37,13-58\r\n53-92,52-91\r\n1-19,3-18\r\n90-91,91-98\r\n20-72,19-71\r\n91-91,1-92\r\n71-90,71-93\r\n77-94,77-94\r\n48-76,48-76\r\n48-58,48-53\r\n3-42,2-14\r\n3-4,3-94\r\n4-9,7-8\r\n14-97,77-97\r\n66-66,17-65\r\n12-99,13-98\r\n29-74,30-74\r\n30-93,29-92\r\n43-44,42-46\r\n7-9,8-81\r\n21-77,1-89\r\n85-92,86-91\r\n56-72,73-73\r\n16-75,17-42\r\n2-85,1-85\r\n97-97,13-98\r\n3-94,3-33\r\n55-91,1-99\r\n14-21,14-15\r\n1-3,2-98\r\n43-57,43-56\r\n9-95,8-10\r\n18-80,81-92\r\n19-72,19-71\r\n17-94,62-86\r\n45-59,46-60\r\n73-88,46-87\r\n63-82,82-86\r\n63-88,87-98\r\n20-28,20-56\r\n76-76,70-75\r\n36-73,35-73\r\n85-91,85-90\r\n4-82,4-85\r\n2-2,1-98\r\n27-71,27-81\r\n13-79,13-14\r\n32-43,33-42\r\n53-97,98-99\r\n41-62,42-66\r\n23-78,23-77\r\n6-92,6-91\r\n1-86,1-85\r\n3-89,84-90\r\n5-79,78-80\r\n51-73,50-72\r\n48-81,49-82\r\n32-33,33-88\r\n4-97,4-97\r\n13-88,14-65\r\n33-74,32-75\r\n26-48,48-78\r\n1-46,16-33\r\n2-6,6-67\r\n5-93,5-93\r\n5-6,4-22\r\n68-83,38-84\r\n10-70,18-69\r\n10-77,70-76\r\n4-94,3-93\r\n22-95,21-99\r\n32-72,31-92\r\n30-75,29-74\r\n3-96,95-95\r\n96-96,61-81\r\n52-77,53-77\r\n1-2,1-94\r\n4-96,3-98\r\n29-58,30-56\r\n31-49,30-60\r\n33-79,27-80\r\n10-51,8-11\r\n8-36,8-36\r\n36-93,36-92\r\n9-60,10-15\r\n48-80,79-87\r\n39-41,40-49\r\n48-87,64-87\r\n30-34,2-57\r\n81-82,13-81\r\n3-15,15-99\r\n37-72,38-72\r\n10-85,5-84\r\n6-79,78-93\r\n75-80,76-84\r\n55-72,55-55\r\n8-66,9-9\r\n54-64,63-99\r\n6-77,7-48\r\n2-64,1-32\r\n31-91,90-90\r\n19-66,18-94\r\n58-75,26-76\r\n58-60,1-59\r\n90-90,87-91\r\n5-91,5-91\r\n67-67,3-66\r\n13-81,31-36\r\n31-61,23-60\r\n18-92,17-91\r\n85-86,15-86\r\n10-68,9-11\r\n52-85,12-84\r\n7-27,26-26\r\n43-50,21-50\r\n25-75,74-75\r\n7-7,6-24\r\n1-63,42-62\r\n11-12,11-66\r\n25-94,93-93\r\n13-48,31-47\r\n3-58,59-59\r\n1-54,1-1\r\n5-5,5-96\r\n59-70,7-71\r\n18-19,18-81\r\n9-96,10-84\r\n33-41,33-38\r\n1-99,1-98\r\n69-83,68-78\r\n19-82,8-81\r\n2-23,3-24\r\n57-90,57-98\r\n75-83,74-76\r\n68-68,16-69\r\n2-86,1-33\r\n5-92,6-14\r\n51-76,52-75\r\n25-72,24-46\r\n9-76,10-50\r\n5-51,23-52\r\n19-83,20-93\r\n33-69,44-70\r\n22-69,23-69\r\n55-61,40-62\r\n2-16,16-81\r\n66-98,66-96\r\n27-85,28-86\r\n43-93,88-94\r\n19-83,32-82\r\n2-92,26-52\r\n87-87,45-93\r\n40-81,97-99\r\n4-97,98-98\r\n19-95,6-20\r\n52-96,53-53\r\n2-34,2-97\r\n62-83,63-66\r\n9-74,8-81\r\n53-83,53-83\r\n35-73,11-72\r\n9-97,10-95\r\n9-51,10-50\r\n25-27,26-35\r\n45-60,45-46\r\n12-65,28-65\r\n40-92,40-91\r\n5-5,4-98\r\n72-91,90-91\r\n16-87,17-91\r\n97-97,18-96\r\n77-78,75-79\r\n22-48,32-47\r\n70-70,35-69\r\n45-98,99-99\r\n65-83,83-92\r\n2-95,4-88\r\n5-10,10-46\r\n4-84,50-85\r\n58-58,15-59\r\n11-80,3-22\r\n46-48,3-47\r\n29-80,30-30\r\n34-96,5-95\r\n65-97,32-96\r\n26-31,30-46\r\n12-12,12-77\r\n26-92,26-92\r\n29-92,29-90\r\n26-27,27-30\r\n4-30,3-29\r\n29-57,1-28\r\n99-99,42-97\r\n92-97,78-98\r\n3-90,46-91\r\n44-76,43-75\r\n24-28,10-25\r\n1-95,1-52\r\n3-3,3-61\r\n39-94,40-93\r\n41-86,75-94\r\n28-28,26-27\r\n21-94,21-97\r\n12-41,41-54\r\n4-49,3-5\r\n75-90,44-75\r\n4-83,78-82\r\n5-93,93-94\r\n33-90,89-90\r\n12-32,13-98\r\n41-99,98-99\r\n4-67,3-38\r\n95-95,11-95\r\n7-46,7-46\r\n11-18,18-24\r\n7-92,12-57\r\n60-91,90-91\r\n86-94,86-95\r\n11-58,57-57\r\n7-10,10-97\r\n1-46,3-46\r\n1-52,1-2\r\n16-94,74-93\r\n7-98,18-97\r\n8-76,8-74\r\n37-92,54-91\r\n63-86,88-96\r\n4-55,47-58\r\n70-92,91-95\r\n73-77,71-77\r\n3-99,5-99\r\n56-58,56-57\r\n53-73,13-74\r\n88-97,97-97\r\n52-63,51-60\r\n13-94,14-91\r\n2-93,3-99\r\n42-75,67-75\r\n38-39,38-88\r\n8-93,92-97\r\n13-32,17-31\r\n3-17,16-53\r\n1-1,3-95\r\n5-88,4-87\r\n76-89,47-77\r\n5-54,4-55\r\n45-95,90-96\r\n81-89,36-88\r\n31-36,32-60\r\n87-99,10-88\r\n17-89,47-88\r\n26-94,25-99\r\n43-90,42-43\r\n59-87,59-80\r\n34-43,37-41\r\n1-54,1-53\r\n2-91,2-3\r\n40-95,46-95\r\n8-14,14-55\r\n38-52,51-69\r\n16-62,15-63\r\n30-55,31-74\r\n46-59,10-74\r\n35-81,80-88\r\n10-86,10-98\r\n18-68,18-68\r\n5-50,5-92\r\n48-98,99-99\r\n6-71,4-72\r\n6-6,6-43\r\n27-39,26-36\r\n15-15,14-82\r\n91-98,29-92\r\n46-51,50-52\r\n5-99,5-98\r\n4-91,4-92\r\n82-83,81-85\r\n68-78,21-68\r\n32-70,69-93\r\n25-59,25-60\r\n40-52,40-40\r\n28-68,93-94\r\n13-99,50-98\r\n10-33,10-11\r\n11-46,8-11\r\n20-32,19-31\r\n9-63,3-62\r\n24-92,92-97\r\n57-68,68-69\r\n39-91,39-91\r\n57-97,49-83\r\n2-58,21-92\r\n14-99,15-98\r\n42-90,43-51\r\n51-51,20-51\r\n29-43,39-43\r\n8-91,7-99\r\n11-75,11-76\r\n33-98,34-97\r\n99-99,28-97\r\n35-82,11-35\r\n80-82,45-81\r\n52-56,53-55\r\n29-77,28-93\r\n6-95,1-94\r\n12-77,12-13\r\n28-90,27-29\r\n71-74,72-77\r\n4-97,4-97\r\n40-85,39-60\r\n36-38,25-38\r\n25-35,24-28\r\n20-57,51-54\r\n80-81,3-81\r\n18-98,97-98\r\n82-94,71-83\r\n5-95,6-87\r\n16-78,3-79\r\n3-74,4-75\r\n14-87,13-42\r\n93-93,8-94\r\n7-20,9-21\r\n6-76,6-7\r\n4-98,69-99\r\n67-95,94-94\r\n66-87,79-86\r\n45-94,45-46\r\n9-13,10-46\r\n71-84,8-83\r\n3-56,4-82\r\n35-89,36-61\r\n54-77,53-55\r\n46-95,46-94\r\n9-19,7-19\r\n18-19,19-42\r\n37-54,53-54\r\n14-91,14-90\r\n9-35,9-36\r\n20-20,20-45\r\n96-97,25-83\r\n11-55,10-10\r\n10-95,11-89\r\n30-34,30-86\r\n30-37,35-38\r\n70-71,53-71\r\n6-12,6-10\r\n4-34,34-95\r\n48-79,48-72\r\n5-99,6-6\r\n60-77,78-94\r\n64-64,13-63\r\n13-31,14-30\r\n7-23,8-24\r\n87-92,88-93\r\n34-81,35-74\r\n7-58,8-77\r\n3-98,3-99\r\n7-94,94-95\r\n3-12,2-88\r\n21-97,22-72\r\n13-77,95-97\r\n15-77,15-16\r\n67-82,68-83\r\n28-28,25-56\r\n51-52,33-52\r\n12-90,12-90\r\n24-72,25-99\r\n1-56,3-55\r\n40-84,39-84\r\n8-9,8-86\r\n31-71,31-72\r\n76-90,64-75\r\n19-90,91-91\r\n42-70,45-69\r\n51-93,80-92\r\n21-36,22-37\r\n96-99,97-97\r\n83-99,1-98\r\n40-43,34-61\r\n1-97,2-96\r\n1-92,1-91\r\n11-92,9-73\r\n57-57,56-66\r\n13-71,12-75\r\n70-89,70-71\r\n12-24,16-24\r\n10-35,56-63\r\n18-85,51-76\r\n20-46,1-45\r\n4-64,4-64\r\n48-52,48-50\r\n84-85,17-85\r\n48-64,63-64\r\n19-28,27-29\r\n4-16,3-17\r\n29-66,2-28\r\n8-88,55-70\r\n60-84,61-85\r\n8-69,8-69\r\n15-67,3-68\r\n42-95,96-99\r\n21-55,22-54\r\n64-70,19-71\r\n17-82,17-81\r\n4-80,3-81\r\n7-95,7-73\r\n12-34,4-33\r\n3-95,63-96\r\n1-96,93-94\r\n45-50,36-49\r\n63-89,45-64\r\n8-96,9-87\r\n93-93,1-92\r\n10-11,10-11\r\n2-6,6-99\r\n40-41,40-68\r\n4-91,3-90\r\n4-68,66-68\r\n37-84,36-85\r\n15-85,29-86\r\n77-79,53-78\r\n50-81,80-81\r\n51-66,50-72\r\n53-53,29-54\r\n42-78,5-77\r\n35-53,36-76\r\n17-17,18-18\r\n4-79,4-79\r\n23-38,23-38\r\n46-81,80-80\r\n26-93,25-37\r\n59-61,20-60\r\n82-96,82-94\r\n16-40,17-21\r\n5-95,5-98\r\n26-26,26-64\r\n32-40,32-75\r\n3-55,6-54\r\n28-86,28-86\r\n4-87,4-96\r\n4-88,24-99\r\n4-66,5-5\r\n9-61,8-89\r\n48-70,48-70\r\n36-37,14-37\r\n21-49,21-50\r\n57-62,14-35\r\n8-62,8-66\r\n14-96,11-97\r\n13-44,43-44\r\n12-87,11-86\r\n2-24,25-97\r\n3-83,2-98\r\n10-80,10-80\r\n4-94,2-4\r\n1-77,20-77\r\n28-79,17-79\r\n8-82,7-7\r\n6-87,77-82\r\n4-93,3-65\r\n94-94,38-95\r\n74-92,74-93\r\n13-68,12-69\r\n41-51,41-42\r\n22-93,21-23\r\n7-12,13-64\r\n58-87,51-88\r\n18-66,19-91\r\n1-70,71-71\r\n9-17,8-37\r\n3-32,4-97\r\n54-90,27-91\r\n1-94,3-93\r\n3-99,4-70\r\n16-92,16-91\r\n22-57,22-57\r\n4-78,31-53\r\n28-94,28-29\r\n19-48,16-18\r\n48-68,49-67\r\n23-39,22-24\r\n12-87,23-95\r\n36-47,37-46\r\n66-69,66-68\r\n35-94,36-93\r\n13-22,2-20\r\n41-53,52-54\r\n4-51,3-96\r\n52-52,5-53\r\n20-85,19-84\r\n4-78,3-79\r\n86-98,15-97\r\n68-85,68-87\r\n2-55,3-54\r\n27-63,11-64\r\n75-83,52-83\r\n18-75,19-74\r\n7-88,8-87\r\n1-86,1-92\r\n6-43,38-44\r\n71-71,70-71\r\n6-43,24-83\r\n15-53,15-63\r\n69-97,69-69\r\n9-99,12-13\r\n31-41,41-42\r\n11-53,10-57\r\n46-67,14-70\r\n24-35,25-36\r\n13-91,23-90\r\n62-67,68-70\r\n62-99,63-68\r\n10-84,51-85\r\n5-98,1-98\r\n16-97,81-98\r\n51-92,41-52\r\n15-88,14-93\r\n3-92,2-93\r\n44-74,44-74\r\n4-95,94-96\r\n51-62,25-63\r\n28-69,11-68\r\n3-82,3-78\r\n5-95,5-98\r\n25-96,25-99\r\n9-9,9-66\r\n17-18,1-18\r\n2-86,4-85\r\n4-9,9-92\r\n2-98,2-98\r\n61-96,60-98\r\n1-89,35-50\r\n89-89,25-90\r\n1-99,1-33\r\n53-73,52-74\r\n30-55,29-90\r\n97-98,70-91\r\n66-69,65-66\r\n31-83,82-83\r\n2-67,67-95\r\n77-78,77-96\r\n30-98,30-98\r\n94-94,28-95\r\n37-83,8-82\r\n14-46,28-30\r\n75-80,12-81\r\n19-68,18-19\r\n65-85,96-99\r\n62-63,3-63\r\n19-95,97-97\r\n54-79,55-78\r\n12-98,97-99\r\n83-98,41-84\r\n68-88,34-69\r\n25-25,20-25\r\n2-66,8-99\r\n84-85,21-85\r\n52-98,53-87\r\n32-55,31-54\r\n4-51,6-90\r\n46-86,47-47\r\n75-75,10-76\r\n30-38,29-49\r\n5-96,4-5\r\n49-49,49-93\r\n8-67,39-65\r\n6-51,5-70\r\n38-70,39-69\r\n2-98,2-3\r\n51-53,50-59\r\n56-92,57-91\r\n11-90,11-52\r\n19-99,20-98\r\n54-77,52-55\r\n6-93,1-6\r\n62-80,58-62\r\n27-82,26-97\r\n10-79,9-78\r\n18-99,18-99\r\n7-87,7-84\r\n44-44,45-86\r\n89-91,6-90\r\n15-98,15-95\r\n56-59,54-60\r\n61-89,2-82\r\n30-78,12-96\r\n10-84,1-10\r\n61-62,46-62\r\n5-74,5-6\r\n29-33,30-32\r\n81-95,95-99\r\n51-98,50-85\r\n6-79,49-78\r\n47-52,12-61\r\n4-58,3-89\r\n75-94,31-76\r\n43-49,42-44\r\n3-4,4-47\r\n44-98,98-98\r\n67-72,66-72\r\n2-38,3-38\r\n3-5,4-47\r\n5-95,5-95\r\n34-97,35-78\r\n66-68,67-98\r\n28-32,29-35\r\n44-68,31-44\r\n28-53,27-55\r\n16-73,17-67\r\n12-49,49-97\r\n34-76,75-75\r\n38-96,37-43\r\n15-20,20-79\r\n15-22,22-35\r\n3-25,4-55\r\n6-90,6-89\r\n17-74,18-75\r\n15-60,14-61\r\n6-29,29-81\r\n23-66,11-24\r\n37-90,90-90\r\n1-24,2-57\r\n42-78,41-79\r\n94-99,74-95\r\n95-97,2-30\r\n13-61,56-60\r\n23-82,24-83\r\n56-56,31-57\r\n58-91,57-99\r\n13-25,14-24\r\n46-54,47-77\r\n47-74,73-74\r\n23-48,22-82\r\n79-80,81-81\r\n16-33,6-76\r\n54-70,55-70\r\n44-67,45-66\r\n2-4,3-97\r\n24-94,19-94\r\n33-77,49-93\r\n13-35,35-73\r\n28-84,28-83\r\n6-89,7-90\r\n40-80,42-80\r\n39-84,65-83\r\n83-83,59-84\r\n20-46,30-46\r\n31-34,32-46\r\n12-13,13-67\r\n35-75,34-74\r\n20-20,20-89\r\n13-70,5-60\r\n25-25,24-24\r\n84-87,83-86\r\n26-58,26-58\r\n6-96,5-7\r\n4-78,5-79\r\n15-15,15-27\r\n7-79,3-80\r\n62-64,24-63\r\n68-69,32-71\r\n27-68,28-41\r\n43-43,11-44\r\n27-82,83-83\r\n54-70,26-69\r\n16-16,17-70\r\n27-34,33-35\r\n33-97,96-97\r\n4-5,4-39\r\n43-43,43-92\r\n27-33,1-28\r\n23-91,23-58\r\n9-51,8-10\r\n4-6,5-76\r\n5-34,33-95\r\n97-98,46-98\r\n20-53,52-65\r\n7-72,6-96\r\n32-79,93-95\r\n21-86,20-85\r\n47-82,46-84\r\n9-96,8-86\r\n10-93,11-75\r\n11-12,11-77\r\n7-56,6-55\r\n3-7,7-43\r\n54-84,55-55\r\n3-95,3-97\r\n18-55,37-56\r\n40-68,39-91\r\n56-87,56-85\r\n12-34,13-35\r\n7-62,8-63\r\n95-95,54-95\r\n7-94,6-94\r\n14-92,13-99\r\n18-42,42-53\r\n75-96,76-95\r\n5-78,4-6\r\n93-94,14-94\r\n25-91,25-92\r\n96-98,97-99\r\n82-84,82-85\r\n37-39,38-42\r\n11-48,7-49\r\n64-66,65-90\r\n10-46,9-45\r\n35-92,34-52\r\n6-94,9-93\r\n12-96,95-96\r\n16-86,63-67\r\n5-96,5-96\r\n54-59,19-60\r\n3-92,3-52\r\n26-54,27-53\r\n28-97,28-93\r\n98-98,83-97\r\n64-98,13-99\r\n79-84,80-86\r\n5-98,4-97\r\n2-23,22-35\r\n7-11,7-87\r\n31-94,32-59\r\n25-41,17-42\r\n28-94,76-95\r\n6-93,5-94\r\n73-94,74-93\r\n6-44,17-44\r\n2-99,22-46\r\n1-73,1-72\r\n25-71,25-72\r\n35-36,6-36\r\n6-66,5-66\r\n92-95,92-95\r\n53-75,52-75\r\n5-55,3-97\r\n12-76,43-75\r\n5-49,13-48\r\n32-32,8-37\r\n18-96,19-19\r\n17-59,17-60\r\n1-17,2-95\r\n37-82,83-83\r\n39-79,39-39\r\n25-81,25-86\r\n11-52,51-51\r\n91-91,30-91\r\n43-58,44-57\r\n1-98,2-98\r\n31-62,31-62\r\n6-13,6-13\r\n65-92,13-91\r\n3-6,5-95\r\n21-88,14-21\r\n48-75,47-74\r\n70-93,30-92\r\n37-58,58-89\r\n14-24,14-23\r\n31-60,58-83\r\n4-95,1-56\r\n47-79,98-98\r\n36-65,37-38\r\n6-18,19-75\r\n14-50,98-99\r\n44-94,45-93\r\n37-39,38-56\r\n39-57,38-40\r\n7-36,6-90\r\n81-83,28-82\r\n15-86,15-77\r\n70-86,2-44\r\n8-23,7-23\r\n28-31,29-78\r\n5-67,4-66\r\n31-31,14-32\r\n45-95,13-96\r\n11-39,40-40\r\n6-95,21-94\r\n35-35,35-66\r\n4-97,4-98\r\n2-97,96-97\r\n14-14,13-50\r\n3-62,2-54\r\n3-98,54-98\r\n24-87,23-86\r\n29-84,28-78\r\n42-45,41-55\r\n8-32,10-33\r\n35-39,35-77\r\n10-89,23-59\r\n10-82,6-98\r\n52-84,83-84\r\n65-73,60-72\r\n7-75,74-91\r\n50-77,76-93\r\n1-94,2-95\r\n98-98,21-97\r\n19-79,18-24\r\n3-87,86-88\r\n47-47,41-48\r\n28-95,29-96\r\n71-85,70-72\r\n60-98,61-75\r\n3-7,7-96\r\n22-23,22-50\r\n90-92,38-91\r\n83-89,57-88\r\n6-86,7-87\r\n3-98,28-99\r\n52-62,15-62\r\n23-98,24-24\r\n38-86,87-94\r\n10-43,16-42\r\n17-25,18-76\r\n60-62,16-63\r\n66-89,66-88\r\n42-80,21-79\r\n6-91,6-93\r\n8-41,41-41\r\n80-87,79-99\r\n88-88,14-89\r\n35-76,23-75\r\n8-51,7-88\r\n2-99,41-71\r\n6-8,7-99\r\n18-83,18-19\r\n69-91,50-68\r\n28-43,28-29\r\n57-76,9-58\r\n56-58,52-57\r\n13-64,14-81\r\n6-84,5-83\r\n95-97,61-77\r\n9-11,10-12\r\n46-65,46-66\r\n18-83,17-83\r\n86-88,57-87\r\n15-74,79-99\r\n5-99,98-99\r\n13-16,14-69\r\n23-92,22-98\r\n70-96,69-98\r\n9-12,9-13\r\n10-12,11-52\r\n21-70,20-87\r\n44-88,44-84\r\n84-86,10-85\r\n30-92,30-91\r\n10-26,25-79\r\n42-59,41-42\r\n39-72,33-99\r\n19-66,39-66\r\n21-23,2-80\r\n23-23,22-23\r\n73-99,72-97\r\n4-72,3-5\r\n22-75,21-76\r\n24-53,52-52\r\n40-56,55-64\r\n17-85,18-84\r\n15-18,14-85\r\n8-71,3-8\r\n1-99,3-95\r\n41-41,40-96\r\n60-67,37-68\r\n9-26,10-91\r\n30-92,73-92\r\n44-85,45-86\r\n13-75,42-75\r\n11-11,64-83\r\n7-98,7-99\r\n53-57,37-54\r\n71-72,8-71\r\n86-86,7-86\r\n14-32,15-54\r\n13-20,12-12\r\n68-93,72-94\r\n3-68,3-4\r\n4-98,17-97\r\n15-94,41-83\r\n23-72,23-72\r\n26-86,2-27\r\n36-81,37-55\r\n10-94,9-93\r\n32-84,31-83\r\n44-95,14-45\r\n3-62,3-62\r\n46-78,45-66\r\n96-98,3-97\r\n91-92,31-92\r\n50-57,20-58\r\n1-64,3-64\r\n48-80,35-48\r\n69-90,69-91\r\n62-68,40-67\r\n74-76,74-76\r\n42-81,43-82\r\n16-58,58-59\r\n88-89,1-89\r\n68-69,69-90\r\n57-73,57-68\r\n58-83,58-94\r\n2-60,88-94\r\n14-18,13-20\r\n68-82,81-83\r\n77-79,26-78\r\n20-36,19-99\r\n12-87,13-89\r\n54-88,64-87\r\n12-85,12-86\r\n1-88,87-89\r\n43-64,64-81\r\n38-97,37-48\r\n12-73,57-74\r\n25-52,26-53\r\n22-22,21-37\r\n75-97,74-76\r\n13-54,14-32\r\n16-47,16-48\r\n9-93,10-92\r\n50-50,49-88\r\n10-10,10-76\r\n94-94,2-95\r\n33-93,63-92\r\n46-46,16-47\r\n90-97,1-91\r\n24-63,26-63\r\n38-84,19-62\r\n28-96,95-98\r\n56-56,49-58\r\n6-83,19-82\r\n31-87,77-88\r\n4-97,3-99\r\n13-86,14-85\r\n90-90,23-90\r\n8-25,26-26\r\n17-60,18-89\r\n10-61,11-62\r\n13-59,50-59\r\n52-73,34-73\r\n94-97,33-95\r\n20-93,19-97\r\n6-6,6-94\r\n7-81,6-89\r\n4-95,4-95\r\n9-65,65-66\r\n37-72,71-75\r\n57-96,56-72\r\n23-77,76-76\r\n7-89,6-88\r\n1-86,85-86\r\n42-44,43-93\r\n18-59,27-58\r\n19-88,18-95\r\n1-74,3-73\r\n22-67,54-66\r\n23-28,23-27\r\n6-73,6-73\r\n4-85,3-5\r\n46-95,46-96\r\n5-92,4-86\r\n22-61,21-61\r\n70-84,56-95\r\n8-9,8-85\r\n18-42,41-41\r\n12-97,96-97\r\n67-73,40-74\r\n13-74,13-81\r\n3-36,4-98\r\n8-96,5-6\r\n9-89,9-84\r\n67-85,68-84\r\n68-69,45-69\r\n34-66,66-71\r\n50-83,13-82\r\n31-74,32-83\r\n1-3,3-83\r\n4-88,4-4\r\n12-93,9-94\r\n70-98,30-98";
        var a = input
            .Split("\r\n")
            .Where(x =>
            {
                var pairs = x.Split(',');
                var pair1 = (int.Parse(pairs[0].Split('-')[0]), int.Parse(pairs[0].Split('-')[1]));
                var pair2 = (int.Parse(pairs[1].Split('-')[0]), int.Parse(pairs[1].Split('-')[1]));
                return (pair1.Item1 >= pair2.Item1 && pair1.Item2 <= pair2.Item2) || (pair2.Item1 >= pair1.Item1 && pair2.Item2 <= pair1.Item2);
            })
        .Count();
        Console.WriteLine(a);
    }

    private static void Day4Part2()
    {
        var input = "22-65,22-66\r\n91-94,63-91\r\n6-88,5-31\r\n85-86,64-86\r\n40-65,40-65\r\n25-82,24-94\r\n68-69,68-92\r\n60-91,89-92\r\n3-72,3-73\r\n44-85,84-85\r\n15-72,14-72\r\n84-92,84-92\r\n10-84,3-10\r\n32-62,31-61\r\n14-98,98-99\r\n24-78,24-61\r\n2-5,5-89\r\n58-95,58-59\r\n39-93,92-93\r\n11-82,81-82\r\n12-37,13-58\r\n53-92,52-91\r\n1-19,3-18\r\n90-91,91-98\r\n20-72,19-71\r\n91-91,1-92\r\n71-90,71-93\r\n77-94,77-94\r\n48-76,48-76\r\n48-58,48-53\r\n3-42,2-14\r\n3-4,3-94\r\n4-9,7-8\r\n14-97,77-97\r\n66-66,17-65\r\n12-99,13-98\r\n29-74,30-74\r\n30-93,29-92\r\n43-44,42-46\r\n7-9,8-81\r\n21-77,1-89\r\n85-92,86-91\r\n56-72,73-73\r\n16-75,17-42\r\n2-85,1-85\r\n97-97,13-98\r\n3-94,3-33\r\n55-91,1-99\r\n14-21,14-15\r\n1-3,2-98\r\n43-57,43-56\r\n9-95,8-10\r\n18-80,81-92\r\n19-72,19-71\r\n17-94,62-86\r\n45-59,46-60\r\n73-88,46-87\r\n63-82,82-86\r\n63-88,87-98\r\n20-28,20-56\r\n76-76,70-75\r\n36-73,35-73\r\n85-91,85-90\r\n4-82,4-85\r\n2-2,1-98\r\n27-71,27-81\r\n13-79,13-14\r\n32-43,33-42\r\n53-97,98-99\r\n41-62,42-66\r\n23-78,23-77\r\n6-92,6-91\r\n1-86,1-85\r\n3-89,84-90\r\n5-79,78-80\r\n51-73,50-72\r\n48-81,49-82\r\n32-33,33-88\r\n4-97,4-97\r\n13-88,14-65\r\n33-74,32-75\r\n26-48,48-78\r\n1-46,16-33\r\n2-6,6-67\r\n5-93,5-93\r\n5-6,4-22\r\n68-83,38-84\r\n10-70,18-69\r\n10-77,70-76\r\n4-94,3-93\r\n22-95,21-99\r\n32-72,31-92\r\n30-75,29-74\r\n3-96,95-95\r\n96-96,61-81\r\n52-77,53-77\r\n1-2,1-94\r\n4-96,3-98\r\n29-58,30-56\r\n31-49,30-60\r\n33-79,27-80\r\n10-51,8-11\r\n8-36,8-36\r\n36-93,36-92\r\n9-60,10-15\r\n48-80,79-87\r\n39-41,40-49\r\n48-87,64-87\r\n30-34,2-57\r\n81-82,13-81\r\n3-15,15-99\r\n37-72,38-72\r\n10-85,5-84\r\n6-79,78-93\r\n75-80,76-84\r\n55-72,55-55\r\n8-66,9-9\r\n54-64,63-99\r\n6-77,7-48\r\n2-64,1-32\r\n31-91,90-90\r\n19-66,18-94\r\n58-75,26-76\r\n58-60,1-59\r\n90-90,87-91\r\n5-91,5-91\r\n67-67,3-66\r\n13-81,31-36\r\n31-61,23-60\r\n18-92,17-91\r\n85-86,15-86\r\n10-68,9-11\r\n52-85,12-84\r\n7-27,26-26\r\n43-50,21-50\r\n25-75,74-75\r\n7-7,6-24\r\n1-63,42-62\r\n11-12,11-66\r\n25-94,93-93\r\n13-48,31-47\r\n3-58,59-59\r\n1-54,1-1\r\n5-5,5-96\r\n59-70,7-71\r\n18-19,18-81\r\n9-96,10-84\r\n33-41,33-38\r\n1-99,1-98\r\n69-83,68-78\r\n19-82,8-81\r\n2-23,3-24\r\n57-90,57-98\r\n75-83,74-76\r\n68-68,16-69\r\n2-86,1-33\r\n5-92,6-14\r\n51-76,52-75\r\n25-72,24-46\r\n9-76,10-50\r\n5-51,23-52\r\n19-83,20-93\r\n33-69,44-70\r\n22-69,23-69\r\n55-61,40-62\r\n2-16,16-81\r\n66-98,66-96\r\n27-85,28-86\r\n43-93,88-94\r\n19-83,32-82\r\n2-92,26-52\r\n87-87,45-93\r\n40-81,97-99\r\n4-97,98-98\r\n19-95,6-20\r\n52-96,53-53\r\n2-34,2-97\r\n62-83,63-66\r\n9-74,8-81\r\n53-83,53-83\r\n35-73,11-72\r\n9-97,10-95\r\n9-51,10-50\r\n25-27,26-35\r\n45-60,45-46\r\n12-65,28-65\r\n40-92,40-91\r\n5-5,4-98\r\n72-91,90-91\r\n16-87,17-91\r\n97-97,18-96\r\n77-78,75-79\r\n22-48,32-47\r\n70-70,35-69\r\n45-98,99-99\r\n65-83,83-92\r\n2-95,4-88\r\n5-10,10-46\r\n4-84,50-85\r\n58-58,15-59\r\n11-80,3-22\r\n46-48,3-47\r\n29-80,30-30\r\n34-96,5-95\r\n65-97,32-96\r\n26-31,30-46\r\n12-12,12-77\r\n26-92,26-92\r\n29-92,29-90\r\n26-27,27-30\r\n4-30,3-29\r\n29-57,1-28\r\n99-99,42-97\r\n92-97,78-98\r\n3-90,46-91\r\n44-76,43-75\r\n24-28,10-25\r\n1-95,1-52\r\n3-3,3-61\r\n39-94,40-93\r\n41-86,75-94\r\n28-28,26-27\r\n21-94,21-97\r\n12-41,41-54\r\n4-49,3-5\r\n75-90,44-75\r\n4-83,78-82\r\n5-93,93-94\r\n33-90,89-90\r\n12-32,13-98\r\n41-99,98-99\r\n4-67,3-38\r\n95-95,11-95\r\n7-46,7-46\r\n11-18,18-24\r\n7-92,12-57\r\n60-91,90-91\r\n86-94,86-95\r\n11-58,57-57\r\n7-10,10-97\r\n1-46,3-46\r\n1-52,1-2\r\n16-94,74-93\r\n7-98,18-97\r\n8-76,8-74\r\n37-92,54-91\r\n63-86,88-96\r\n4-55,47-58\r\n70-92,91-95\r\n73-77,71-77\r\n3-99,5-99\r\n56-58,56-57\r\n53-73,13-74\r\n88-97,97-97\r\n52-63,51-60\r\n13-94,14-91\r\n2-93,3-99\r\n42-75,67-75\r\n38-39,38-88\r\n8-93,92-97\r\n13-32,17-31\r\n3-17,16-53\r\n1-1,3-95\r\n5-88,4-87\r\n76-89,47-77\r\n5-54,4-55\r\n45-95,90-96\r\n81-89,36-88\r\n31-36,32-60\r\n87-99,10-88\r\n17-89,47-88\r\n26-94,25-99\r\n43-90,42-43\r\n59-87,59-80\r\n34-43,37-41\r\n1-54,1-53\r\n2-91,2-3\r\n40-95,46-95\r\n8-14,14-55\r\n38-52,51-69\r\n16-62,15-63\r\n30-55,31-74\r\n46-59,10-74\r\n35-81,80-88\r\n10-86,10-98\r\n18-68,18-68\r\n5-50,5-92\r\n48-98,99-99\r\n6-71,4-72\r\n6-6,6-43\r\n27-39,26-36\r\n15-15,14-82\r\n91-98,29-92\r\n46-51,50-52\r\n5-99,5-98\r\n4-91,4-92\r\n82-83,81-85\r\n68-78,21-68\r\n32-70,69-93\r\n25-59,25-60\r\n40-52,40-40\r\n28-68,93-94\r\n13-99,50-98\r\n10-33,10-11\r\n11-46,8-11\r\n20-32,19-31\r\n9-63,3-62\r\n24-92,92-97\r\n57-68,68-69\r\n39-91,39-91\r\n57-97,49-83\r\n2-58,21-92\r\n14-99,15-98\r\n42-90,43-51\r\n51-51,20-51\r\n29-43,39-43\r\n8-91,7-99\r\n11-75,11-76\r\n33-98,34-97\r\n99-99,28-97\r\n35-82,11-35\r\n80-82,45-81\r\n52-56,53-55\r\n29-77,28-93\r\n6-95,1-94\r\n12-77,12-13\r\n28-90,27-29\r\n71-74,72-77\r\n4-97,4-97\r\n40-85,39-60\r\n36-38,25-38\r\n25-35,24-28\r\n20-57,51-54\r\n80-81,3-81\r\n18-98,97-98\r\n82-94,71-83\r\n5-95,6-87\r\n16-78,3-79\r\n3-74,4-75\r\n14-87,13-42\r\n93-93,8-94\r\n7-20,9-21\r\n6-76,6-7\r\n4-98,69-99\r\n67-95,94-94\r\n66-87,79-86\r\n45-94,45-46\r\n9-13,10-46\r\n71-84,8-83\r\n3-56,4-82\r\n35-89,36-61\r\n54-77,53-55\r\n46-95,46-94\r\n9-19,7-19\r\n18-19,19-42\r\n37-54,53-54\r\n14-91,14-90\r\n9-35,9-36\r\n20-20,20-45\r\n96-97,25-83\r\n11-55,10-10\r\n10-95,11-89\r\n30-34,30-86\r\n30-37,35-38\r\n70-71,53-71\r\n6-12,6-10\r\n4-34,34-95\r\n48-79,48-72\r\n5-99,6-6\r\n60-77,78-94\r\n64-64,13-63\r\n13-31,14-30\r\n7-23,8-24\r\n87-92,88-93\r\n34-81,35-74\r\n7-58,8-77\r\n3-98,3-99\r\n7-94,94-95\r\n3-12,2-88\r\n21-97,22-72\r\n13-77,95-97\r\n15-77,15-16\r\n67-82,68-83\r\n28-28,25-56\r\n51-52,33-52\r\n12-90,12-90\r\n24-72,25-99\r\n1-56,3-55\r\n40-84,39-84\r\n8-9,8-86\r\n31-71,31-72\r\n76-90,64-75\r\n19-90,91-91\r\n42-70,45-69\r\n51-93,80-92\r\n21-36,22-37\r\n96-99,97-97\r\n83-99,1-98\r\n40-43,34-61\r\n1-97,2-96\r\n1-92,1-91\r\n11-92,9-73\r\n57-57,56-66\r\n13-71,12-75\r\n70-89,70-71\r\n12-24,16-24\r\n10-35,56-63\r\n18-85,51-76\r\n20-46,1-45\r\n4-64,4-64\r\n48-52,48-50\r\n84-85,17-85\r\n48-64,63-64\r\n19-28,27-29\r\n4-16,3-17\r\n29-66,2-28\r\n8-88,55-70\r\n60-84,61-85\r\n8-69,8-69\r\n15-67,3-68\r\n42-95,96-99\r\n21-55,22-54\r\n64-70,19-71\r\n17-82,17-81\r\n4-80,3-81\r\n7-95,7-73\r\n12-34,4-33\r\n3-95,63-96\r\n1-96,93-94\r\n45-50,36-49\r\n63-89,45-64\r\n8-96,9-87\r\n93-93,1-92\r\n10-11,10-11\r\n2-6,6-99\r\n40-41,40-68\r\n4-91,3-90\r\n4-68,66-68\r\n37-84,36-85\r\n15-85,29-86\r\n77-79,53-78\r\n50-81,80-81\r\n51-66,50-72\r\n53-53,29-54\r\n42-78,5-77\r\n35-53,36-76\r\n17-17,18-18\r\n4-79,4-79\r\n23-38,23-38\r\n46-81,80-80\r\n26-93,25-37\r\n59-61,20-60\r\n82-96,82-94\r\n16-40,17-21\r\n5-95,5-98\r\n26-26,26-64\r\n32-40,32-75\r\n3-55,6-54\r\n28-86,28-86\r\n4-87,4-96\r\n4-88,24-99\r\n4-66,5-5\r\n9-61,8-89\r\n48-70,48-70\r\n36-37,14-37\r\n21-49,21-50\r\n57-62,14-35\r\n8-62,8-66\r\n14-96,11-97\r\n13-44,43-44\r\n12-87,11-86\r\n2-24,25-97\r\n3-83,2-98\r\n10-80,10-80\r\n4-94,2-4\r\n1-77,20-77\r\n28-79,17-79\r\n8-82,7-7\r\n6-87,77-82\r\n4-93,3-65\r\n94-94,38-95\r\n74-92,74-93\r\n13-68,12-69\r\n41-51,41-42\r\n22-93,21-23\r\n7-12,13-64\r\n58-87,51-88\r\n18-66,19-91\r\n1-70,71-71\r\n9-17,8-37\r\n3-32,4-97\r\n54-90,27-91\r\n1-94,3-93\r\n3-99,4-70\r\n16-92,16-91\r\n22-57,22-57\r\n4-78,31-53\r\n28-94,28-29\r\n19-48,16-18\r\n48-68,49-67\r\n23-39,22-24\r\n12-87,23-95\r\n36-47,37-46\r\n66-69,66-68\r\n35-94,36-93\r\n13-22,2-20\r\n41-53,52-54\r\n4-51,3-96\r\n52-52,5-53\r\n20-85,19-84\r\n4-78,3-79\r\n86-98,15-97\r\n68-85,68-87\r\n2-55,3-54\r\n27-63,11-64\r\n75-83,52-83\r\n18-75,19-74\r\n7-88,8-87\r\n1-86,1-92\r\n6-43,38-44\r\n71-71,70-71\r\n6-43,24-83\r\n15-53,15-63\r\n69-97,69-69\r\n9-99,12-13\r\n31-41,41-42\r\n11-53,10-57\r\n46-67,14-70\r\n24-35,25-36\r\n13-91,23-90\r\n62-67,68-70\r\n62-99,63-68\r\n10-84,51-85\r\n5-98,1-98\r\n16-97,81-98\r\n51-92,41-52\r\n15-88,14-93\r\n3-92,2-93\r\n44-74,44-74\r\n4-95,94-96\r\n51-62,25-63\r\n28-69,11-68\r\n3-82,3-78\r\n5-95,5-98\r\n25-96,25-99\r\n9-9,9-66\r\n17-18,1-18\r\n2-86,4-85\r\n4-9,9-92\r\n2-98,2-98\r\n61-96,60-98\r\n1-89,35-50\r\n89-89,25-90\r\n1-99,1-33\r\n53-73,52-74\r\n30-55,29-90\r\n97-98,70-91\r\n66-69,65-66\r\n31-83,82-83\r\n2-67,67-95\r\n77-78,77-96\r\n30-98,30-98\r\n94-94,28-95\r\n37-83,8-82\r\n14-46,28-30\r\n75-80,12-81\r\n19-68,18-19\r\n65-85,96-99\r\n62-63,3-63\r\n19-95,97-97\r\n54-79,55-78\r\n12-98,97-99\r\n83-98,41-84\r\n68-88,34-69\r\n25-25,20-25\r\n2-66,8-99\r\n84-85,21-85\r\n52-98,53-87\r\n32-55,31-54\r\n4-51,6-90\r\n46-86,47-47\r\n75-75,10-76\r\n30-38,29-49\r\n5-96,4-5\r\n49-49,49-93\r\n8-67,39-65\r\n6-51,5-70\r\n38-70,39-69\r\n2-98,2-3\r\n51-53,50-59\r\n56-92,57-91\r\n11-90,11-52\r\n19-99,20-98\r\n54-77,52-55\r\n6-93,1-6\r\n62-80,58-62\r\n27-82,26-97\r\n10-79,9-78\r\n18-99,18-99\r\n7-87,7-84\r\n44-44,45-86\r\n89-91,6-90\r\n15-98,15-95\r\n56-59,54-60\r\n61-89,2-82\r\n30-78,12-96\r\n10-84,1-10\r\n61-62,46-62\r\n5-74,5-6\r\n29-33,30-32\r\n81-95,95-99\r\n51-98,50-85\r\n6-79,49-78\r\n47-52,12-61\r\n4-58,3-89\r\n75-94,31-76\r\n43-49,42-44\r\n3-4,4-47\r\n44-98,98-98\r\n67-72,66-72\r\n2-38,3-38\r\n3-5,4-47\r\n5-95,5-95\r\n34-97,35-78\r\n66-68,67-98\r\n28-32,29-35\r\n44-68,31-44\r\n28-53,27-55\r\n16-73,17-67\r\n12-49,49-97\r\n34-76,75-75\r\n38-96,37-43\r\n15-20,20-79\r\n15-22,22-35\r\n3-25,4-55\r\n6-90,6-89\r\n17-74,18-75\r\n15-60,14-61\r\n6-29,29-81\r\n23-66,11-24\r\n37-90,90-90\r\n1-24,2-57\r\n42-78,41-79\r\n94-99,74-95\r\n95-97,2-30\r\n13-61,56-60\r\n23-82,24-83\r\n56-56,31-57\r\n58-91,57-99\r\n13-25,14-24\r\n46-54,47-77\r\n47-74,73-74\r\n23-48,22-82\r\n79-80,81-81\r\n16-33,6-76\r\n54-70,55-70\r\n44-67,45-66\r\n2-4,3-97\r\n24-94,19-94\r\n33-77,49-93\r\n13-35,35-73\r\n28-84,28-83\r\n6-89,7-90\r\n40-80,42-80\r\n39-84,65-83\r\n83-83,59-84\r\n20-46,30-46\r\n31-34,32-46\r\n12-13,13-67\r\n35-75,34-74\r\n20-20,20-89\r\n13-70,5-60\r\n25-25,24-24\r\n84-87,83-86\r\n26-58,26-58\r\n6-96,5-7\r\n4-78,5-79\r\n15-15,15-27\r\n7-79,3-80\r\n62-64,24-63\r\n68-69,32-71\r\n27-68,28-41\r\n43-43,11-44\r\n27-82,83-83\r\n54-70,26-69\r\n16-16,17-70\r\n27-34,33-35\r\n33-97,96-97\r\n4-5,4-39\r\n43-43,43-92\r\n27-33,1-28\r\n23-91,23-58\r\n9-51,8-10\r\n4-6,5-76\r\n5-34,33-95\r\n97-98,46-98\r\n20-53,52-65\r\n7-72,6-96\r\n32-79,93-95\r\n21-86,20-85\r\n47-82,46-84\r\n9-96,8-86\r\n10-93,11-75\r\n11-12,11-77\r\n7-56,6-55\r\n3-7,7-43\r\n54-84,55-55\r\n3-95,3-97\r\n18-55,37-56\r\n40-68,39-91\r\n56-87,56-85\r\n12-34,13-35\r\n7-62,8-63\r\n95-95,54-95\r\n7-94,6-94\r\n14-92,13-99\r\n18-42,42-53\r\n75-96,76-95\r\n5-78,4-6\r\n93-94,14-94\r\n25-91,25-92\r\n96-98,97-99\r\n82-84,82-85\r\n37-39,38-42\r\n11-48,7-49\r\n64-66,65-90\r\n10-46,9-45\r\n35-92,34-52\r\n6-94,9-93\r\n12-96,95-96\r\n16-86,63-67\r\n5-96,5-96\r\n54-59,19-60\r\n3-92,3-52\r\n26-54,27-53\r\n28-97,28-93\r\n98-98,83-97\r\n64-98,13-99\r\n79-84,80-86\r\n5-98,4-97\r\n2-23,22-35\r\n7-11,7-87\r\n31-94,32-59\r\n25-41,17-42\r\n28-94,76-95\r\n6-93,5-94\r\n73-94,74-93\r\n6-44,17-44\r\n2-99,22-46\r\n1-73,1-72\r\n25-71,25-72\r\n35-36,6-36\r\n6-66,5-66\r\n92-95,92-95\r\n53-75,52-75\r\n5-55,3-97\r\n12-76,43-75\r\n5-49,13-48\r\n32-32,8-37\r\n18-96,19-19\r\n17-59,17-60\r\n1-17,2-95\r\n37-82,83-83\r\n39-79,39-39\r\n25-81,25-86\r\n11-52,51-51\r\n91-91,30-91\r\n43-58,44-57\r\n1-98,2-98\r\n31-62,31-62\r\n6-13,6-13\r\n65-92,13-91\r\n3-6,5-95\r\n21-88,14-21\r\n48-75,47-74\r\n70-93,30-92\r\n37-58,58-89\r\n14-24,14-23\r\n31-60,58-83\r\n4-95,1-56\r\n47-79,98-98\r\n36-65,37-38\r\n6-18,19-75\r\n14-50,98-99\r\n44-94,45-93\r\n37-39,38-56\r\n39-57,38-40\r\n7-36,6-90\r\n81-83,28-82\r\n15-86,15-77\r\n70-86,2-44\r\n8-23,7-23\r\n28-31,29-78\r\n5-67,4-66\r\n31-31,14-32\r\n45-95,13-96\r\n11-39,40-40\r\n6-95,21-94\r\n35-35,35-66\r\n4-97,4-98\r\n2-97,96-97\r\n14-14,13-50\r\n3-62,2-54\r\n3-98,54-98\r\n24-87,23-86\r\n29-84,28-78\r\n42-45,41-55\r\n8-32,10-33\r\n35-39,35-77\r\n10-89,23-59\r\n10-82,6-98\r\n52-84,83-84\r\n65-73,60-72\r\n7-75,74-91\r\n50-77,76-93\r\n1-94,2-95\r\n98-98,21-97\r\n19-79,18-24\r\n3-87,86-88\r\n47-47,41-48\r\n28-95,29-96\r\n71-85,70-72\r\n60-98,61-75\r\n3-7,7-96\r\n22-23,22-50\r\n90-92,38-91\r\n83-89,57-88\r\n6-86,7-87\r\n3-98,28-99\r\n52-62,15-62\r\n23-98,24-24\r\n38-86,87-94\r\n10-43,16-42\r\n17-25,18-76\r\n60-62,16-63\r\n66-89,66-88\r\n42-80,21-79\r\n6-91,6-93\r\n8-41,41-41\r\n80-87,79-99\r\n88-88,14-89\r\n35-76,23-75\r\n8-51,7-88\r\n2-99,41-71\r\n6-8,7-99\r\n18-83,18-19\r\n69-91,50-68\r\n28-43,28-29\r\n57-76,9-58\r\n56-58,52-57\r\n13-64,14-81\r\n6-84,5-83\r\n95-97,61-77\r\n9-11,10-12\r\n46-65,46-66\r\n18-83,17-83\r\n86-88,57-87\r\n15-74,79-99\r\n5-99,98-99\r\n13-16,14-69\r\n23-92,22-98\r\n70-96,69-98\r\n9-12,9-13\r\n10-12,11-52\r\n21-70,20-87\r\n44-88,44-84\r\n84-86,10-85\r\n30-92,30-91\r\n10-26,25-79\r\n42-59,41-42\r\n39-72,33-99\r\n19-66,39-66\r\n21-23,2-80\r\n23-23,22-23\r\n73-99,72-97\r\n4-72,3-5\r\n22-75,21-76\r\n24-53,52-52\r\n40-56,55-64\r\n17-85,18-84\r\n15-18,14-85\r\n8-71,3-8\r\n1-99,3-95\r\n41-41,40-96\r\n60-67,37-68\r\n9-26,10-91\r\n30-92,73-92\r\n44-85,45-86\r\n13-75,42-75\r\n11-11,64-83\r\n7-98,7-99\r\n53-57,37-54\r\n71-72,8-71\r\n86-86,7-86\r\n14-32,15-54\r\n13-20,12-12\r\n68-93,72-94\r\n3-68,3-4\r\n4-98,17-97\r\n15-94,41-83\r\n23-72,23-72\r\n26-86,2-27\r\n36-81,37-55\r\n10-94,9-93\r\n32-84,31-83\r\n44-95,14-45\r\n3-62,3-62\r\n46-78,45-66\r\n96-98,3-97\r\n91-92,31-92\r\n50-57,20-58\r\n1-64,3-64\r\n48-80,35-48\r\n69-90,69-91\r\n62-68,40-67\r\n74-76,74-76\r\n42-81,43-82\r\n16-58,58-59\r\n88-89,1-89\r\n68-69,69-90\r\n57-73,57-68\r\n58-83,58-94\r\n2-60,88-94\r\n14-18,13-20\r\n68-82,81-83\r\n77-79,26-78\r\n20-36,19-99\r\n12-87,13-89\r\n54-88,64-87\r\n12-85,12-86\r\n1-88,87-89\r\n43-64,64-81\r\n38-97,37-48\r\n12-73,57-74\r\n25-52,26-53\r\n22-22,21-37\r\n75-97,74-76\r\n13-54,14-32\r\n16-47,16-48\r\n9-93,10-92\r\n50-50,49-88\r\n10-10,10-76\r\n94-94,2-95\r\n33-93,63-92\r\n46-46,16-47\r\n90-97,1-91\r\n24-63,26-63\r\n38-84,19-62\r\n28-96,95-98\r\n56-56,49-58\r\n6-83,19-82\r\n31-87,77-88\r\n4-97,3-99\r\n13-86,14-85\r\n90-90,23-90\r\n8-25,26-26\r\n17-60,18-89\r\n10-61,11-62\r\n13-59,50-59\r\n52-73,34-73\r\n94-97,33-95\r\n20-93,19-97\r\n6-6,6-94\r\n7-81,6-89\r\n4-95,4-95\r\n9-65,65-66\r\n37-72,71-75\r\n57-96,56-72\r\n23-77,76-76\r\n7-89,6-88\r\n1-86,85-86\r\n42-44,43-93\r\n18-59,27-58\r\n19-88,18-95\r\n1-74,3-73\r\n22-67,54-66\r\n23-28,23-27\r\n6-73,6-73\r\n4-85,3-5\r\n46-95,46-96\r\n5-92,4-86\r\n22-61,21-61\r\n70-84,56-95\r\n8-9,8-85\r\n18-42,41-41\r\n12-97,96-97\r\n67-73,40-74\r\n13-74,13-81\r\n3-36,4-98\r\n8-96,5-6\r\n9-89,9-84\r\n67-85,68-84\r\n68-69,45-69\r\n34-66,66-71\r\n50-83,13-82\r\n31-74,32-83\r\n1-3,3-83\r\n4-88,4-4\r\n12-93,9-94\r\n70-98,30-98";
        var a = input
            .Split("\r\n")
            .Where(x =>
            {
                var pairs = x.Split(',');
                var pair1 = (int.Parse(pairs[0].Split('-')[0]), int.Parse(pairs[0].Split('-')[1]));
                var pair2 = (int.Parse(pairs[1].Split('-')[0]), int.Parse(pairs[1].Split('-')[1]));
                return pair1.Item1 <= pair2.Item2 && pair2.Item1 <= pair1.Item2;
            })
        .Count();
        Console.WriteLine(a);
    }
}