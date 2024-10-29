# SpartaDungeon3D
SSC_Unity_6gen_SpartaDungeon3D

## [프로젝트 소개]
SpartaDungeon3D
개인프로젝트_Unity3D 입문 및 경험키우기

개발환경 - C#, Visual Studio

---
## [프로젝트 목표]
- Unity 3D에 관련된 기술 습득하기
- 3D에서 사용되는 물리 계산 공부하기

---
## [개발 기간]
2024.10.28~2024.10.29

---

## [기능 구현]
### 1. 움직이는 플랫폼 , 점프시 스태미나 감소
![움직이는_플랫폼_점프스태미나감소](https://github.com/user-attachments/assets/837ac236-07e7-4d5a-a0d3-1c67b5f3cb86)  

![image](https://github.com/user-attachments/assets/45c296fc-3a02-495a-9ea1-2bf9df13ce6d)  
▲움직이는 플랫폼의 Trigger에 닿는 오브젝트의 Transform을 자식으로 이동시켜 구현하였습니다.
![image](https://github.com/user-attachments/assets/9fb584cd-d251-4989-aee7-2b942b936e84)  
▲점프시 스태미나 10을 감소하는 로직입니다. (매직넘버 이슈_다음 프로젝트 진행시 수정 필요)

---

### 2. 아이템 획득시 효과 적용
![아이템획득시효과 적용](https://github.com/user-attachments/assets/1c069208-bc21-4ce0-98ea-10e02ab89128)  
▲ 각종 아이템 획득시 HP회복,스태미나회복, 이동속도 일정시간 증가 아이템을 구현 하였습니다.

![image](https://github.com/user-attachments/assets/4d2b63b5-5ee5-4cab-9828-9f2496c3f9e0)  
▲소모아이템의 타입에 따라 스탯이 적용 되고 해당 데이터가 버프타입이면 코루틴으로 수치를 원복합니다.

---

#### 3. 점프 플랫폼 
![점프플랫폼](https://github.com/user-attachments/assets/5e6a9e09-cc5a-48ce-a158-ddd374e45323)  
▲ 점프플랫폼 위로 올라가는 경우 캐릭터 오브젝트를 지정한 Power로 위로 힘을 가합니다.

---

### 4. 상호작용 오브젝트 UI 박스 표시
![상호작용오브젝트 UI박스 표시](https://github.com/user-attachments/assets/9bde7541-51f6-42f1-b173-9e43ccda62d8)  
▲InterActable 레이어에 속한 오브젝트들을 캐릭터의 Ray에 닿은 경우 UI박스가 표시됩니다.  

![image](https://github.com/user-attachments/assets/2c1cda8a-8804-4d96-beac-6b9d6ff050da)  
▲Ray를 발사하여 해당되는 레이어마스크를 검출한뒤 UI 박스를 표기하는 로직입니다.

---

### 5. 레이저 트랩 감지
![레이저트랩감지](https://github.com/user-attachments/assets/b344c446-869c-424a-8b59-eb1bd6f19bdd)  
▲레이저 트랩에 플레이어 객체가 닿는 경우 콘솔 화면에 레이저에 감지되었다고 출력됩니다.

![image](https://github.com/user-attachments/assets/7e2e82fb-805d-4629-bf48-d34b9c17ca45)  
▲Ray를 이용하여 쉽게 구현 하였습니다. 해당 함수에 레이저트랩에 감지 되었을경우의 코드를 작성하면됩니다.

---

### 6. 발사대 플랫폼
![발사대플랫폼](https://github.com/user-attachments/assets/8e60f3e0-1b4d-4654-b0c4-d7736b2257ab)  
▲플랫폼이 기운 방향으로 캐릭터를 발사 시킵니다.

![image](https://github.com/user-attachments/assets/fa0d12c9-8283-4e4c-8f6a-a4f675d9a8e9)  
▲X축을 회전시켜 발사하는 각도의 방향을 선언후 [쿼터니언 x 벡터] 연산을하여 발사하는 방향벡터를  
구한뒤 X,Z축의 이동값은 ExtraDir로 따로 보정하였고 Y축 이동량은 PlayerController의 Jump메서드를 재활용하였습니다.

---

### 7. 벽 매달리기 및 벽 이동하기
![벽매달리기및이동](https://github.com/user-attachments/assets/6e698730-8e3c-4bf4-9fbf-2d9d620bf1b2)  
▲플레이어의 Ray에 감지되면 벽이 감지되면 벽에 매달린 상태가 되고 벽이동을 AddForce로 이동하게 됩니다.
Ray가 벗어나게되면 캐릭터는 떨어지게 됩니다.

![image](https://github.com/user-attachments/assets/5fc5ea59-09b7-460d-9a8c-84d33cac3827)  
▲플레이어 오브젝트의 RigidBody 컴포넌트를 호출하여 벽에 붙는경우 중력을 해지하고 벽에서 떨어지는 중력을 적용 시키는 방식으로 구현하였습니다.

---

