const { Builder,
By, Key,
until } = require('selenium-webdriver')



const assert =
require('assert')









describe('apsiyonTest',
function() {



  this.timeout(30000)



  let driver



  let vars



  beforeEach(async function() {



    driver =
await new Builder().forBrowser('chrome').build()



    vars = {}



  })









  afterEach(async function() {



    await driver.quit();



  })









  it('apsiyonTest',
async function() {



    // Test name: apsiyonTest



    // Step # | name | target | value



    // 1 | open | / | 



    await driver.get("https://www.n11.com/")



    // 2 | setWindowSize | 1366x728 |



    await driver.manage().window().setRect(1366,
728)



    // 3 | Sayfa yüklendi mi Assertion

    assert.strictEqual(driver.findElement(By.linkText("Giriş
 Yap")).isDisplayed,
true, "Sayfa Yüklenemedi");



    // 4 | click | linkText=Giriş Yap |



    await driver.findElement(By.linkText("Giriş
 Yap")).click()



    // 5 | click | id=email |



    await driver.findElement(By.id("email")).click()



    // 6 | type | id=email | denizdemireltest91@gmail.com



    await driver.findElement(By.id("email")).sendKeys("denizdemireltest91@gmail.com")



    // 7 | type | id=password | 513700Tu



    await driver.findElement(By.id("password")).sendKeys("513700Tu")



    // 8 | click | css=.rememberMe |



    await driver.findElement(By.css(".rememberMe")).click()



    // 9 | click | id=loginButton |



    await driver.findElement(By.id("loginButton")).click()





    // 10 | click | id=searchData |



    await driver.findElement(By.id("searchData")).click()



    // 11 | type | id=searchData | samsung



    await driver.findElement(By.id("searchData")).sendKeys("samsung")



    // 12 | click | css=.iconSearch |



    await driver.findElement(By.css(".iconSearch")).click()



    // 13 | Arama Sonucu Assertion



    assert.strictEqual(driver.findElement(By.className("productDisplayPrice")).isDisplayed,
true, "Arama sonucuna göre veri alınamadı")





  })



})
