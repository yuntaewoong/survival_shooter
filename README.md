# survival_shooter  
----------------------
![screenshot_1](https://user-images.githubusercontent.com/38284288/40973181-4121be6a-68fe-11e8-912f-aea3bd6d6b5c.png)    
**screenshot1 게임 처음실행시**  
unity홈페이지의 asset store에서 필요한 asset들을 import하여 플레이어와 배경 그리고 충돌물들을 배치하였으며  
플레이어는 사용자의 wasd키를 입력받아 위 왼쪽 아래 오른쪽 으로 이동할 수 있다.  
그리고 또 마우스의 왼쪽 키를 입력받아 마우스 커서가 가리키는 위치로 총알을 발사한다.  
player는 idle상태와 move상태에 따라 다른 애니메이션을 가지는데 그것들을 나누는 기준은  
player가 이동하고 있으면 move상태이고 player가 가만히 있으면 idle상태이다.  
![screenshot_2](https://user-images.githubusercontent.com/38284288/40973330-dc3d8b18-68fe-11e8-8127-b6bdecc58171.png)  
**screenshot2 적을 총알로 맞추었을 때**  
적들은 3가지 spawn position을 가지며 해당하는 spawn position에서  
일정시간 마다 적prefab들이 scene에 나오게 된다.  
적의 capsule collider에 총알이 충돌했음을 인식하면 적의 hp가 줄어들고  
충분한 크기의 피해를 입으면 적은 죽는 애니메이션을 실행한뒤 바닥으로 가라앉고  
스크립트에 의해 일정시간 후 사라진다.  
![screenshot_3](https://user-images.githubusercontent.com/38284288/40973525-8511a918-68ff-11e8-887e-c682f900d445.png)  
**screenshot3 또 다른 2가지 적들**  
zombunny zombear hellephant라는 이름을 가진 3가지 적이  
게임에 등장하며 각각의 적은 생긴 특성에 맞게  
다른 능력치들을 가지고 있다. 특히 hellephant는  
큰 덩치에 맞게 느린 spawn 시간과 높은 체력을 가지고 있다.  
![screenshot_4](https://user-images.githubusercontent.com/38284288/40973659-0b66ed70-6900-11e8-99cb-94fb0303eaed.png)
**screenshot4 피해를 입을시**  
player는 체력수치를 가지고 있으며 그것은 화면 왼쪽하단의 slider로 표시된다.  
player의 capsule collider에서 충돌을 인식하면 적의 공격력 수치에 따라  
player의 체력이 떨어지고 slider가 왼쪽으로 이동한다.  
player의 체력이 다 떨어지면 죽는 애니메이션을 실행 후 gameover화면으로 이동한다.  






unity project
