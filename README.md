โปรแกรมสำหรับอาจารย์บันทึกข้อมูลนักศึกษา

ชื่อ: นายธนกร ทิพเนตร
รหัสนักศึกษา: 673450191-2

Class Diagram
![Untitled diagram-2025-03-11-153903](https://github.com/user-attachments/assets/2a83f43b-367d-4bf3-a4c4-98f142b6f3ba)





หลักการเขียนโปรแกรมเชิงวัตถุที่ใช้ในโปรแกรม
โปรแกรมนี้ได้ใช้หลักการเขียนโปรแกรมเชิงวัตถุ (OOP) ตามแนวคิดหลัก ดังนี้:

Encapsulation (การห่อหุ้มข้อมูล)

ใช้ private หรือ protected ในการซ่อนข้อมูลของคลาส เช่น name และ Major ใน BaseData
ใช้ getter และ setter ในคลาส Teacher และ Student เพื่อควบคุมการเข้าถึงข้อมูล
Inheritance (การสืบทอดคลาส)

คลาส Student และ Professor สืบทอดมาจาก BaseData ซึ่งช่วยให้สามารถใช้งานข้อมูลพื้นฐานร่วมกันได้
Polymorphism (พหุนาม)

ใช้การ Override เมทอดในคลาสย่อย เช่น คลาส Student และ Professor
ใช้การ Overloading โดยอาจมีการใช้คอนสตรักเตอร์ที่แตกต่างกันใน Professor
Abstraction (นามธรรม)

มีการใช้ Enum Major และ Student_advisor_ForStudent เพื่อจัดกลุ่มข้อมูลแบบนามธรรม
แยกการจัดการข้อมูลพื้นฐานออกเป็น BAseDAta ทำให้โค้ดอ่านง่ายขึ้น
โครงสร้างของโปรแกรม
1. BaseData
เป็นคลาสพื้นฐานที่เก็บข้อมูลของ Student และ Professor
มี name และ Major
2. Student
สืบทอดจาก BaseData
เก็บข้อมูล ST_ID, Gpx, และ Advisor
มี Enum Student_advisor_ForStudent สำหรับเก็บข้อมูลที่ปรึกษา
3. Teacher
สืบทอดจาก BaseData
เก็บรายชื่อนักศึกษาและวิชาที่สอน
